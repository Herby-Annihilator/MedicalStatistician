using MedicalStatistician.DAL.Entities.Base;
using MedicalStatistician.DAL.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.WebApiClients.Repositories
{
    public class WebRepository<T> : ICrudRepository<T> where T : Entity
    {
        private readonly HttpClient _client;

        public WebRepository(HttpClient client) => _client = client;

        public T Create(T entity)
        {
            var response = _client.PostAsJsonAsync("", entity).Result;
            var result = response
               .EnsureSuccessStatusCode()
               .Content
               .ReadFromJsonAsync<T>()
               .Result;
            return result;
        }

        public async Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            var response = await _client.PostAsJsonAsync("", entity, cancellationToken).ConfigureAwait(false);
            var result = await response
               .EnsureSuccessStatusCode()
               .Content
               .ReadFromJsonAsync<T>(cancellationToken: cancellationToken)
               .ConfigureAwait(false);
            return result;
        }

        public T Delete(T entity)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, "")
            {
                Content = JsonContent.Create(entity)
            };
            var response = _client.SendAsync(request).Result;
            if (response.StatusCode == HttpStatusCode.NotFound)
                return default;
            var result = response
               .EnsureSuccessStatusCode()
               .Content
               .ReadFromJsonAsync<T>()
               .Result;
            return result;
        }

        public async Task<T> DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, "")
            {
                Content = JsonContent.Create(entity)
            };
            var response = await _client.SendAsync(request, cancellationToken).ConfigureAwait(false);
            if (response.StatusCode == HttpStatusCode.NotFound)
                return default;
            var result = await response
               .EnsureSuccessStatusCode()
               .Content
               .ReadFromJsonAsync<T>(cancellationToken: cancellationToken)
               .ConfigureAwait(false);
            return result;
        }

        public IEnumerable<T> Get(int skip, int count)
            => _client.GetFromJsonAsync<IEnumerable<T>>($"items/{skip}/{count}").Result;

        public IEnumerable<T> GetAll() => _client.GetFromJsonAsync<IEnumerable<T>>("").Result;

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _client.GetFromJsonAsync<IEnumerable<T>>("", cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<T>> GetAsync(int skip, int count, CancellationToken cancellationToken = default)
            => await _client.GetFromJsonAsync<IEnumerable<T>>($"items/{skip}/{count}", cancellationToken)
            .ConfigureAwait(false);

        public T GetById(int id) => _client.GetFromJsonAsync<T>($"{id}").Result;

        public async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default)
            => await _client.GetFromJsonAsync<T>($"{id}", cancellationToken).ConfigureAwait(false);

        public IPage<T> GetPage(int pageIndex, int pageSize)
        {
            var response = _client.GetAsync($"page/{pageIndex}/{pageSize}").Result;
            if (response.StatusCode == HttpStatusCode.NotFound)
                return new PageItems
                {
                    Items = Enumerable.Empty<T>(),
                    TotalCount = 0,
                    PageIndex = pageIndex,
                    PageSize = pageSize,
                };
            return response
               .EnsureSuccessStatusCode()
               .Content
               .ReadFromJsonAsync<PageItems>()
               .Result;
        }

        public async Task<IPage<T>> GetPageAsync(int pageIndex, int pageSize, CancellationToken cancellationToken = default)
        {
            var response = await _client.GetAsync($"page/{pageIndex}/{pageSize}", cancellationToken).ConfigureAwait(false);
            if (response.StatusCode == HttpStatusCode.NotFound)
                return new PageItems
                {
                    Items = Enumerable.Empty<T>(),
                    TotalCount = 0,
                    PageIndex = pageIndex,
                    PageSize = pageSize,
                };
            return await response
               .EnsureSuccessStatusCode()
               .Content
               .ReadFromJsonAsync<PageItems>(cancellationToken: cancellationToken)
               .ConfigureAwait(false);
        }

        private class PageItems : IPage<T>
        {
            public IEnumerable<T> Items { get; set; }
            public int TotalCount { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public int TotalPagesCount => (int)Math.Ceiling((double)TotalCount / PageSize);
        }

        public T Update(T entity)
        {
            var response = _client.PutAsJsonAsync("", entity).Result;
            var result = response
               .EnsureSuccessStatusCode()
               .Content
               .ReadFromJsonAsync<T>()
               .Result;
            return result;
        }

        public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            var response = await _client.PutAsJsonAsync("", entity, cancellationToken).ConfigureAwait(false);
            var result = await response
               .EnsureSuccessStatusCode()
               .Content
               .ReadFromJsonAsync<T>(cancellationToken: cancellationToken)
               .ConfigureAwait(false);
            return result;
        }

        protected bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _client.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
