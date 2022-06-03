using MedicalStatistician.API.Controllers.Base;
using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStatistician.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusOfJudgesDecisionUnderArticle35Controller : DefaultCrudController<StatusOfJudgesDecisionUnderArticle35>
    {
        public StatusOfJudgesDecisionUnderArticle35Controller(ICrudRepository<StatusOfJudgesDecisionUnderArticle35> repository) : base(repository)
        {
        }
    }
}
