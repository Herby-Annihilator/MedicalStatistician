using MedicalStatistician.API.Controllers.Base;
using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStatistician.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mkb10Controller : DefaultCrudController<MKB10>
    {
        public Mkb10Controller(ICrudRepository<MKB10> repository) : base(repository)
        {
        }
    }
}
