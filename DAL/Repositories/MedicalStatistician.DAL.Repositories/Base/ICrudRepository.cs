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
    public interface ICrudRepository<T> where T : Entity
    {
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
        /// <returns>Число созданных сущностей</returns>
        int Create(T entity);
        /// <summary>
        /// Асинхорнная версия метода <see cref="Create(T)"/>
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо поместить в хранилище</param>
        /// <param name="cancellationToken">Токен прерывания задачи</param>
        /// <returns>Задача, итогом завершения которой является число созданных сущностей</returns>
        Task<int> CreateAsync(T entity, CancellationToken cancellationToken = default);
        /// <summary>
        /// Обновляет сущность типа <typeparamref name="T"/> в хранилище данных
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо обновить в хранилище</param>
        /// <returns>Число обновленных сущностей</returns>
        int Update(T entity);
        /// <summary>
        /// Асинхорнная версия метода <see cref="Update(T)"/>
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо обновить в хранилище</param>
        /// <param name="cancellationToken">Токен прерывания задачи</param>
        /// <returns>Задача, итогом завершения которой является число обновленных сущностей</returns>
        Task<int> UpdateAsync(T entity, CancellationToken cancellationToken = default);
        /// <summary>
        /// Удаляет сущность типа <typeparamref name="T"/> в хранилище данных
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо удалить в хранилище</param>
        /// <returns>Число удаленных сущностей</returns>
        int Delete(T entity);
        /// <summary>
        /// Асинхорнная версия метода <see cref="Delete(T)"/>
        /// </summary>
        /// <param name="entity">Сущность, которую необходимо удалить в хранилище</param>
        /// <param name="cancellationToken">Токен прерывания задачи</param>
        /// <returns>Задача, итогом завершения которой является число удаленных сущностей</returns>
        Task<int> DeleteAsync(T entity, CancellationToken cancellationToken = default);
    }
}
