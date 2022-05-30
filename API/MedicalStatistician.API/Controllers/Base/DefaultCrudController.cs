using MedicalStatistician.DAL.Entities.Base;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStatistician.API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultCrudController<T> : ControllerBase where T : Entity
    {
        protected ICrudRepository<T> _repository;
        public DefaultCrudController(ICrudRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet("get/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public virtual async Task<ActionResult> GetById(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public virtual async Task<IActionResult> Create(T entity)
        {
            var result = await _repository.CreateAsync(entity);
            if (result == null)
                return NotFound();
            else
                return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public virtual async Task<IActionResult> Update(T entity)
        {
            var result = await _repository.UpdateAsync(entity);
            if (result == null)
                return NotFound();
            else
                return AcceptedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public virtual async Task<ActionResult> Delete(T entity)
        {
            var result = await _repository.DeleteAsync(entity);
            if (result == null)
                return NotFound(entity);
            else
                return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll() => Ok(await _repository.GetAllAsync());

        [HttpGet("items/{skip:int}/{count:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<T>>> Get(int skip, int count) =>
            Ok(await _repository.GetAsync(skip, count));

        [HttpGet("page/{pageIndex:int}/{pageSize:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IPage<T>>> GetPage(int pageIndex, int pageSize)
        {
            var result = await _repository.GetPageAsync(pageIndex, pageSize);
            return result.Items.Any()
                ? Ok(result)
                : NotFound(result);
        }
    }
}
