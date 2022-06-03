using MedicalStatistician.API.Controllers.Base;
using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStatistician.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientEntryRoutesController : DefaultCrudController<PatientEntryRoutes>
    {
        public PatientEntryRoutesController(ICrudRepository<PatientEntryRoutes> repository) : base(repository)
        {
        }
    }
}
