using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BrekkeDanceCenter.Classes.Entities;
using BrekkeDanceCenter.Classes.Authentication;

namespace BrekkeDanceCenter.Classes.Controllers {
    [ApiController]
    [Route("/healthcheck")]
    public class HealthcheckController : ControllerBase {
        private DatabaseContext databaseContext;

        public HealthcheckController(DatabaseContext databaseContext) {
            this.databaseContext = databaseContext;
        }

        [HttpGet]
        public ActionResult<string> Healthcheck() {
            return new ActionResult<string>("OK");
        }
    }
}