using MedicalStatistician.API.Controllers.Base;
using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStatistician.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeOfForcedTreatmentController : DefaultCrudController<TypeOfForcedTreatment>
    {
        public TypeOfForcedTreatmentController(ICrudRepository<TypeOfForcedTreatment> repository) : base(repository)
        {
        }
    }
}
