using DataAccess.Manager;
using DataAccess.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Established_Patient_Form.Controllers
{
    [RoutePrefix("api/main")]
    public class MainController : ApiController
    {
        private DataManager dManager;
        public MainController()
        {
            dManager = new DataManager();
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(dManager.Get());
        }

        [HttpPost]
        [Route("Save")]
        public IHttpActionResult Save(TemplateModel model)
        {
            if (ModelState.IsValid)
            {
                model.Blood_Pressure_Sitting = new BloodPressure(model.Blood_Pressure_Sitting_Manage);
                model.Blood_Pressure_Standing = new BloodPressure(model.Blood_Pressure_Standing_Manage);
                dManager.Save(model);
                return Ok("Template have been saved");
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        [Route("SavePID")]
        public IHttpActionResult SavePID(object model)
        {
            if (model != null)
            {
                dManager.SavePID(model);
                return Ok("PID Template have been saved");
            }
            return BadRequest(ModelState);
        }
    }
}
