using MedicalStatistician.API.Controllers.Base;
using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStatistician.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurposeOfReferralForTreatmentController : DefaultCrudController<PurposeOfReferralForTreatment>
    {
        public PurposeOfReferralForTreatmentController(ICrudRepository<PurposeOfReferralForTreatment> repository) : base(repository)
        {
        }
    }
}
