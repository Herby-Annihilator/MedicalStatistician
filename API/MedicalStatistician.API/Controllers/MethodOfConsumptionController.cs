﻿using MedicalStatistician.API.Controllers.Base;
using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStatistician.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MethodOfConsumptionController : DefaultCrudController<MethodOfConsumption>
    {
        public MethodOfConsumptionController(ICrudRepository<MethodOfConsumption> repository) : base(repository)
        {
        }
    }
}
