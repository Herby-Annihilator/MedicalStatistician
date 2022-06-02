using MedicalStatistician.API.Controllers.Base;
using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStatistician.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiseaseOutcomeController : DefaultCrudController<DiseaseOutcome>
    {
        public DiseaseOutcomeController(ICrudRepository<DiseaseOutcome> repository) : base(repository)
        {
        }
    }
}
