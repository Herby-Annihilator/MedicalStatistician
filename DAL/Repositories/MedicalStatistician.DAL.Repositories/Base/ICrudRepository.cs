using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Repositories.Base
{
    /// <summary>
    /// CRUD репозиторий
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICrudRepository<T> : IDisposable where T : Entity
    {
        /// <summary>
        /// Получает заданное число <paramref name="count"/> сущностей пропустив <paramref name="skip"/> сущностей
        /// </summary>
        /// <param name="skip">Сколько сущностей необходимо пропустить</param>
        /// <param name="count">Сколко сущностей необхдимо получить</param>
        /// <returns></returns>
        IEnumerable<T> Get(int skip, int count);
        /// <summary>
        /// Асинхронная версия метода <see cref="Get(int, int)"/>
        /// </summary>
        /// <param name="skip">Сколько сущностей необходимо пропустить</param>
        /// <param name="count">Сколко сущностей необхдимо получить</param>
        /// <param name="cancellationToken">Токен завершения задачи</param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAsync(int skip, int count, CancellationToken cancellationToken = default);
        /// <summary>
        /// Получает страницу сущностей заданного размера с указанным индексом
        /// </summary>
        /// <param name="pageIndex">индекс страницы</param>
        /// <param name="pageSize">размер страницы</param>
        /// <returns></returns>
        IPage<T> GetPage(int pageIndex, int pageSize);
        /// <summary>
        /// Асинхронная версия метода <see cref="GetPage(int, int)"/>
        /// </summary>
        /// <param name="pageIndex">индекс страницы</param>
        /// <param name="pageSize">размер страницы</param>
        /// <param name="cancellationToken">Токен завершения задачи</param>
        /// <returns></returns>
        Task<IPage<T>> GetPageAsync(int pageIndex, int pageSize, CancellationToken cancellationToken = default);
        /// <summary>
        /// Получает сущность по ее <paramref name="id"/>
        /// </summary>
        /// <param name="id">Идентификатор сущности</param>
        /// <returns>Сущность тип <typeparamref name="T"/></returns>
        T GetById(int id);
        /// <summary>
        /// Асинхронный вариант метода <see cref="GetById(int)"/>
        /// </summary>
        /// <param name="id">Идентификатор сущности</param>
        /// <param name="cancellationToken">Токен прерывания задачи</param>
        /// <returns>Задача, итогом завершения которой является сущность типа <typeparamref name="T"/></returns>
        Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Получает все сущности из хранилища данных
        /// </summary>
        /// <returns>Перечисление сущностей типа <typeparamref name="T"/></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Асинхронная версия метода <see cref="GetAll"/>
        /// </summary>
        /// <param name="cancellationToken">Токен прерывания задачи</param>
        /// <returns>Задача, итогом завершения которой является перечисление сущностей типа <typeparamref name="T"/></returns>
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Создает сущность типа <typeparamref name="T"/> в хранилище данных
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо поместить в хранилище</param>
        /// <returns>Созданная в репозитории сущность с проставленным id</returns>
        T Create(T entity);
        /// <summary>
        /// Асинхорнная версия метода <see cref="Create(T)"/>
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо поместить в хранилище</param>
        /// <param name="cancellationToken">Токен прерывания задачи</param>
        /// <returns>Задача, итогом завершения которой является созданная в репозитории сущность с проставленным id</returns>
        Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);
        /// <summary>
        /// Обновляет сущность типа <typeparamref name="T"/> в хранилище данных
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо обновить в хранилище</param>
        /// <returns>Сама обновленная сущность</returns>
        T Update(T entity);
        /// <summary>
        /// Асинхорнная версия метода <see cref="Update(T)"/>
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо обновить в хранилище</param>
        /// <param name="cancellationToken">Токен прерывания задачи</param>
        /// <returns>Задача, итогом завершения которой является сама обновленная сущность</returns>
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);
        /// <summary>
        /// Удаляет сущность типа <typeparamref name="T"/> в хранилище данных
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо удалить в хранилище</param>
        /// <returns>Сама уадаленная сущность</returns>
        T Delete(T entity);
        /// <summary>
        /// Асинхорнная версия метода <see cref="Delete(T)"/>
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо удалить в хранилище</param>
        /// <param name="cancellationToken">Токен прерывания задачи</param>
        /// <returns>Задача, итогом завершения которой является сама уадаленная сущность</returns>
        Task<T> DeleteAsync(T entity, CancellationToken cancellationToken = default);
    }
}
