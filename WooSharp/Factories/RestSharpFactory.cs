using Bukimedia.WooSharp.Deserializers;
using Bukimedia.WooSharp.Entities;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Bukimedia.WooSharp.Factories
{
    public abstract class RestSharpFactory
    {
        protected string BaseUrl { get; set; }
        protected string Key { get; set; }
        protected string Secret { get; set; }

        /// <summary>
        /// For Wordpress REST API with OAuth 1.0 ONLY
        /// </summary>
        public string OauthToken { get; set; }

        /// <summary>
        /// For Wordpress REST API with OAuth 1.0 ONLY
        /// </summary>
        public string OauthTokenSecret { get; set; }

        public RestSharpFactory(string baseUrl, string key, string secret)
        {
            BaseUrl = baseUrl;
            Key = key;
            Secret = secret;
        }

        #region Privates

        private void AddWcKey(RestRequest request)
        {
            request.AddParameter("consumer_key", Key, ParameterType.QueryString); // used on every request
            request.AddParameter("consumer_secret", Secret, ParameterType.QueryString); // used on every request
        }

        private void AddAuthenticator(RestClient client)
        {
            client.Authenticator = OAuth1Authenticator.ForRequestToken(Key, Secret);
        }

        private void AddBody(RestRequest request, WooCommerceEntity entity)
        {
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = WooSharpDeserializer.Default;
            request.AddJsonBody(entity);
        }

        private void AddBody(RestRequest request, IEnumerable<WooCommerceEntity> entities)
        {
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = WooSharpDeserializer.Default;
            request.AddJsonBody(entities);
        }

        private void AddBody(RestRequest request, Dictionary<string, string> filter)
        {
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = WooSharpDeserializer.Default;
            request.AddJsonBody(filter);
        }

        private void AddHandlers(RestClient client)
        {
            client.ClearHandlers();
            client.AddHandler("application/json", () => WooSharpDeserializer.Default);
            client.AddHandler("text/json", () => WooSharpDeserializer.Default);
            client.AddHandler("text/x-json", () => WooSharpDeserializer.Default);
            client.AddHandler("text/javascript", () => WooSharpDeserializer.Default);
            client.AddHandler("*+json", () => WooSharpDeserializer.Default);
        }

        #endregion

        #region Protected

        protected void CheckResponse(IRestResponse response, RestRequest request)
        {
            if (response.StatusCode == HttpStatusCode.InternalServerError
                || response.StatusCode == HttpStatusCode.ServiceUnavailable
                || response.StatusCode == HttpStatusCode.BadRequest
                || response.StatusCode == HttpStatusCode.Unauthorized
                || response.StatusCode == HttpStatusCode.MethodNotAllowed
                || response.StatusCode == HttpStatusCode.Forbidden
                || response.StatusCode == HttpStatusCode.NotFound
                || response.StatusCode == 0)
            {
                var parsedresponse = JObject.Parse(response.Content);
                throw new WooSharpException((string)parsedresponse["message"],
                    (string)parsedresponse["code"],
                    response.StatusCode,
                    response.ErrorException);
            }
        }

        #endregion

        protected T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(BaseUrl);
            AddWcKey(request);
            //AddAuthenticator(client);
            AddHandlers(client);
            var response = client.Execute<T>(request);
            CheckResponse(response, request);
            return response.Data;
        }

        protected List<int> ExecuteForGetIds<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(BaseUrl);
            AddWcKey(request);
            //AddAuthenticator(client);
            AddHandlers(client);
            var response = client.Execute<T>(request);
            CheckResponse(response, request);
            var parsedResponse = JArray.Parse(response.Content);
            var ids = parsedResponse.Select(x => (int)x["id"]).ToList();
            return ids;
        }

        protected async Task<T> ExecuteAsync<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(BaseUrl);
            AddWcKey(request);
            //AddAuthenticator(client);
            AddHandlers(client);
            var response = await client.ExecuteAsync<T>(request);
            CheckResponse(response, request);
            return response.Data;
        }

        protected async Task<List<long>> ExecuteForGetIdsAsync<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(BaseUrl);
            AddWcKey(request);
            //AddAuthenticator(client);
            AddHandlers(client);
            var response = await client.ExecuteAsync<T>(request);
            CheckResponse(response, request);
            var parsedResponse = JArray.Parse(response.Content);
            var ids = parsedResponse.Select(x => (long)x["id"]).ToList();
            return ids;
        }

        protected RestRequest RequestForGet(string resource, long? id)
        {
            var request = new RestRequest
            {
                Resource = resource + "/{id}",
                Method = Method.GET
            };

            request.AddParameter("id", id, ParameterType.UrlSegment);

            return request;
        }

        protected RestRequest RequestForGetList(string resource, Dictionary<string, string> filters, string order, string limit)
        {
            var request = new RestRequest
            {
                Resource = resource,
                Method = Method.GET
            };

            if (filters != null && filters.Count > 0)
            {
                foreach (KeyValuePair<string, string> entry in filters)
                {
                    request.AddParameter(entry.Key, entry.Value, ParameterType.QueryString);
                }
            }

            if (!string.IsNullOrEmpty(order))
            {
                request.AddParameter("order", order, ParameterType.QueryString);
            }

            if (!string.IsNullOrEmpty(limit))
            {
                request.AddParameter("per_page", limit, ParameterType.QueryString);
            }

            return request;
        }

        protected RestRequest RequestForAdd(string resource, WooCommerceEntity wooCommerceEntity)
        {
            var request = new RestRequest
            {
                Resource = resource,
                Method = Method.POST
            };

            this.AddBody(request, wooCommerceEntity);

            return request;
        }
        protected RestRequest RequestForAddList(string resource, IEnumerable<WooCommerceEntity> wooCommerceEntities)
        {
            var request = new RestRequest
            {
                Resource = resource,
                Method = Method.POST
            };

            this.AddBody(request, wooCommerceEntities);

            return request;
        }

        protected RestRequest RequestForUpdate(string resource, long? id, WooCommerceEntity wooCommerceEntity)
        {
            if (id == null) throw new ApplicationException("Id is required to update something.");
            var request = new RestRequest
            {
                Resource = resource + "/{id}",
                Method = Method.PUT

            };
            request.AddParameter("id", id, ParameterType.UrlSegment);
            this.AddBody(request, wooCommerceEntity);

            return request;
        }

        protected RestRequest RequestForUpdateList(string resource, IEnumerable<WooCommerceEntity> wooCommerceEntities)
        {
            var request = new RestRequest
            {
                Resource = resource + "/batch",
                Method = Method.PUT
            };
            this.AddBody(request, wooCommerceEntities);
            return request;
        }

        protected RestRequest RequestForDelete(string resource, long? id)
        {
            if (id == null) throw new ApplicationException("Id is required to delete something.");
            var request = new RestRequest
            {
                Resource = resource + "/{id}",
                Method = Method.DELETE,
            };

            request.AddParameter("id", id, ParameterType.UrlSegment);

            return request;
        }
    }
}