using MedicalStatistician.API.Controllers.Base;
using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStatistician.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController()]
    public class HivTestController : DefaultCrudController<HivTest>
    {
        public HivTestController(ICrudRepository<HivTest> repository) : base(repository)
        {
        }
    }
}
