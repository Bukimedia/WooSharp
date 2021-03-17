using Bukimedia.WooSharp.Entities;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bukimedia.WooSharp.Factories
{
    public abstract class SubFactory<T> : RestSharpFactory where T : WooCommerceEntity, IWooCommerceFactoryEntity, new()
    {
        protected abstract string entityName { get; }
        protected abstract string parentEntityName { get; }

        public SubFactory(string BaseUrl, string Key, string Secret) : base(BaseUrl, Key, Secret)
        {
        }

        public T Get(long parentId, long id)
        {
            RestRequest request = this.RequestForGet(this.GetResourceForParentId(parentId), id);
            return this.Execute<T>(request);
        }

        public List<T> GetAll(long parentId)
        {
            RestRequest request = this.RequestForGetList(this.GetResourceForParentId(parentId), null, null, null);
            return this.Execute<List<T>>(request);
        }

        public List<int> GetIds(long parentId)
        {
            RestRequest request = this.RequestForGetList(this.GetResourceForParentId(parentId), null, null, null);
            return this.ExecuteForGetIds<List<T>>(request);
        }

        public List<T> GetByFilter(long parentId, Dictionary<string, string> filter)
        {
            RestRequest request = this.RequestForGetList(this.GetResourceForParentId(parentId), filter, null, null);
            return this.Execute<List<T>>(request);
        }

        public List<T> GetByFilter(long parentId, Dictionary<string, string> Filter, string order, string limit)
        {
            RestRequest request = this.RequestForGetList(this.GetResourceForParentId(parentId), Filter, order, limit);
            return this.Execute<List<T>>(request);
        }

        public List<int> GetIdsByFilter(long parentId, Dictionary<string, string> filter, string order, string limit)
        {
            RestRequest request = this.RequestForGetList(this.GetResourceForParentId(parentId), filter, order, limit);
            return this.ExecuteForGetIds<List<T>>(request);
        }

        public T Add(long parentId, T Entity)
        {
            int? idAux = Entity.id;
            Entity.id = null;
            RestRequest request = this.RequestForAdd(this.GetResourceForParentId(parentId), Entity);
            T aux = this.Execute<T>(request);
            Entity.id = idAux;
            return this.Get(parentId, (int)aux.id);
        }
        public List<T> AddList(long parentId, List<T> Entities)
        {
            List<WooCommerceEntity> EntitiesToAdd = new List<WooCommerceEntity>();
            foreach (T Entity in Entities)
            {
                Entity.id = null;
                EntitiesToAdd.Add(Entity);
            }
            RestRequest request = this.RequestForAddList(this.GetResourceForParentId(parentId), EntitiesToAdd);
            return this.Execute<List<T>>(request);
        }

        public void Update(long parentId, T Entity)
        {
            RestRequest request = this.RequestForUpdate(this.GetResourceForParentId(parentId), Entity.id, Entity);
            this.Execute<T>(request);
        }

        public List<T> UpdateList(long parentId, List<T> Entities)
        {
            List<WooCommerceEntity> EntitiesToAdd = new List<WooCommerceEntity>();
            foreach (T Entity in Entities)
            {
                EntitiesToAdd.Add(Entity);
            }

            RestRequest request = this.RequestForUpdateList(this.GetResourceForParentId(parentId), EntitiesToAdd);

            return this.Execute<List<T>>(request);
        }

        public void Delete(long parentId, long id)
        {
            RestRequest request = this.RequestForDelete(this.GetResourceForParentId(parentId), id);
            this.Execute<T>(request);
        }

        public void Delete(long parentId, T Entity)
        {
            this.Delete(parentId, (long)Entity.id);
        }

        public async Task<T> GetAsync(long parentId, long id)
        {
            RestRequest request = this.RequestForGet(this.GetResourceForParentId(parentId), id);
            return await this.ExecuteAsync<T>(request);
        }

        public async Task<List<T>> GetAllAsync(long parentId)
        {
            RestRequest request = this.RequestForGetList(this.GetResourceForParentId(parentId), null, null, null);
            return await this.ExecuteAsync<List<T>>(request);
        }

        public async Task<List<long>> GetIdsAsync(long parentId)
        {
            RestRequest request = this.RequestForGetList(this.GetResourceForParentId(parentId), null, null, null);
            return await this.ExecuteForGetIdsAsync<List<long>>(request);
        }

        public async Task<List<T>> GetByFilterAsync(long parentId, Dictionary<string, string> filter)
        {
            RestRequest request = this.RequestForGetList(this.GetResourceForParentId(parentId), filter, null, null);
            return await this.ExecuteAsync<List<T>>(request);
        }

        public async Task<List<T>> GetByFilterAsync(long parentId, Dictionary<string, string> filter, string order, string limit)
        {
            RestRequest request = this.RequestForGetList(this.GetResourceForParentId(parentId), filter, order, limit);
            return await this.ExecuteAsync<List<T>>(request);
        }

        public async Task<List<long>> GetIdsByFilterAsync(long parentId, Dictionary<string, string> filter, string order, string limit)
        {
            RestRequest request = this.RequestForGetList(this.GetResourceForParentId(parentId), filter, order, limit);
            return await this.ExecuteForGetIdsAsync<List<T>>(request);
        }

        public async Task<T> AddAsync(long parentId, T Entity)
        {
            int? idAux = Entity.id;
            Entity.id = null;
            RestRequest request = this.RequestForAdd(this.GetResourceForParentId(parentId), Entity);
            T aux = await this.ExecuteAsync<T>(request);
            Entity.id = idAux;
            return this.Get(parentId, (int)aux.id);
        }

        public async Task UpdateAsync(long parentId, T Entity)
        {
            RestRequest request = this.RequestForUpdate(this.GetResourceForParentId(parentId), Entity.id, Entity);
            await this.ExecuteAsync<T>(request);
        }

        public async Task<List<T>> UpdateListAsync(long parentId, List<T> Entities)
        {
            List<WooCommerceEntity> EntitiesToAdd = new List<WooCommerceEntity>();
            foreach (T Entity in Entities)
            {
                EntitiesToAdd.Add(Entity);
            }

            RestRequest request = this.RequestForUpdateList(this.GetResourceForParentId(parentId), EntitiesToAdd);

            return await this.ExecuteAsync<List<T>>(request);
        }

        public async Task DeleteAsync(long parentId, long id)
        {
            RestRequest request = this.RequestForDelete(this.GetResourceForParentId(parentId), id);
            await this.ExecuteAsync<T>(request);
        }

        public Task DeleteAsync(long parentId, T Entity)
        {
            return this.DeleteAsync(parentId, (long)Entity.id);
        }

        private string GetResourceForParentId(long parentId)
        {
            return parentEntityName + '/' + parentId + '/' + entityName;
        }
    }
}
