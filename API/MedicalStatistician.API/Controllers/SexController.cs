using MedicalStatistician.API.Controllers.Base;
using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStatistician.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SexController : DefaultCrudController<Sex>
    {
        public SexController(ICrudRepository<Sex> repository) : base(repository)
        {
        }
    }
}
