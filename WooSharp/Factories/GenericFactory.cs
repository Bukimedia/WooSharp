using Bukimedia.WooSharp.Entities;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bukimedia.WooSharp.Factories
{
    public abstract class GenericFactory<T> : RestSharpFactory where T : WooCommerceEntity, IWooCommerceFactoryEntity, new()
    {
        protected abstract string entityName { get; }

        public GenericFactory(string BaseUrl, string Key, string Secret) : base(BaseUrl, Key, Secret)
        {
        }

        public T Get(long id)
        {
            RestRequest request = this.RequestForGet(entityName, id);
            return this.Execute<T>(request);
        }

        public List<T> GetAll()
        {
            RestRequest request = this.RequestForGetList(entityName, null, null, null);
            return this.Execute<List<T>>(request);
        }

        public List<int> GetIds()
        {
            RestRequest request = this.RequestForGetList(entityName, null, null, null);
            return this.ExecuteForGetIds<List<T>>(request);
        }

        public List<T> GetByFilter(Dictionary<string, string> filter)
        {
            RestRequest request = this.RequestForGetList(entityName, filter, null, null);
            return this.Execute<List<T>>(request);
        }

        public List<T> GetByFilter(Dictionary<string, string> Filter, string order, string limit)
        {
            RestRequest request = this.RequestForGetList(entityName, Filter, order, limit);
            return this.Execute<List<T>>(request);
        }

        public List<int> GetIdsByFilter(Dictionary<string, string> filter, string order, string limit)
        {
            RestRequest request = this.RequestForGetList(entityName, filter, order, limit);
            return this.ExecuteForGetIds<List<T>>(request);
        }

        public T Add(T Entity)
        {
            int? idAux = Entity.id;
            Entity.id = null;
            RestRequest request = this.RequestForAdd(entityName, Entity);
            T aux = this.Execute<T>(request);
            Entity.id = idAux;
            return this.Get((int)aux.id);
        }
        public List<T> AddList(List<T> Entities)
        {
            List<WooCommerceEntity> EntitiesToAdd = new List<WooCommerceEntity>();
            foreach (T Entity in Entities)
            {
                Entity.id = null;
                EntitiesToAdd.Add(Entity);
            }
            RestRequest request = this.RequestForAddList(entityName, EntitiesToAdd);
            return this.Execute<List<T>>(request);
        }

        public void Update(T Entity)
        {
            RestRequest request = this.RequestForUpdate(entityName, Entity.id, Entity);
            this.Execute<T>(request);
        }

        public List<T> UpdateList(List<T> Entities)
        {
            List<WooCommerceEntity> EntitiesToAdd = new List<WooCommerceEntity>();
            foreach (T Entity in Entities)
            {
                EntitiesToAdd.Add(Entity);
            }

            RestRequest request = this.RequestForUpdateList(entityName, EntitiesToAdd);

            return this.Execute<List<T>>(request);
        }

        public void Delete(long id)
        {
            RestRequest request = this.RequestForDelete(entityName, id);
            this.Execute<T>(request);
        }

        public void Delete(T Entity)
        {
            this.Delete((long)Entity.id);
        }

        public async Task<T> GetAsync(long id)
        {
            RestRequest request = this.RequestForGet(entityName, id);
            return await this.ExecuteAsync<T>(request);
        }

        public async Task<List<T>> GetAllAsync()
        {
            RestRequest request = this.RequestForGetList(entityName, null, null, null);
            return await this.ExecuteAsync<List<T>>(request);
        }

        public async Task<List<long>> GetIdsAsync()
        {
            RestRequest request = this.RequestForGetList(entityName, null, null, null);
            return await this.ExecuteForGetIdsAsync<List<long>>(request);
        }

        public async Task<List<T>> GetByFilterAsync(Dictionary<string, string> filter)
        {
            RestRequest request = this.RequestForGetList(entityName, filter, null, null);
            return await this.ExecuteAsync<List<T>>(request);
        }

        public async Task<List<T>> GetByFilterAsync(Dictionary<string, string> filter, string order, string limit)
        {
            RestRequest request = this.RequestForGetList(entityName, filter, order, limit);
            return await this.ExecuteAsync<List<T>>(request);
        }

        public async Task<List<long>> GetIdsByFilterAsync(Dictionary<string, string> filter, string order, string limit)
        {
            RestRequest request = this.RequestForGetList(entityName, filter, order, limit);
            return await this.ExecuteForGetIdsAsync<List<T>>(request);
        }

        public async Task<T> AddAsync(T Entity)
        {
            int? idAux = Entity.id;
            Entity.id = null;
            RestRequest request = this.RequestForAdd(entityName, Entity);
            T aux = await this.ExecuteAsync<T>(request);
            Entity.id = idAux;
            return this.Get((int)aux.id);
        }

        public async Task UpdateAsync(T Entity)
        {
            RestRequest request = this.RequestForUpdate(entityName, Entity.id, Entity);
            await this.ExecuteAsync<T>(request);
        }

        public async Task<List<T>> UpdateListAsync(List<T> Entities)
        {
            List<WooCommerceEntity> EntitiesToAdd = new List<WooCommerceEntity>();
            foreach (T Entity in Entities)
            {
                EntitiesToAdd.Add(Entity);
            }

            RestRequest request = this.RequestForUpdateList(entityName, EntitiesToAdd);

            return await this.ExecuteAsync<List<T>>(request);
        }

        public async Task DeleteAsync(long id)
        {
            RestRequest request = this.RequestForDelete(entityName, id);
            await this.ExecuteAsync<T>(request);
        }

        public Task DeleteAsync(T Entity)
        {
            return this.DeleteAsync((long)Entity.id);
        }
    }
}
