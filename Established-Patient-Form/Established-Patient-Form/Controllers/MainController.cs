using DataAccess.Manager;
using DataAccess.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Established_Patient_Form.Controllers
{
    public class MainController : ApiController
    {
        private DataManager dManager;
        public MainController()
        {
            dManager = new DataManager();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(dManager.Get());
        }

        [HttpPost]
        public IHttpActionResult Add(TemplateModel model)
        {
            var errors = Validation(model);
            foreach (var er in errors)
            {
                ModelState.AddModelError("Validation error", er);
            }
            if (ModelState.IsValid)
            {
                dManager.Save(model);
                return Ok("Template have been saved");
            }
            return BadRequest(ModelState);
        }

        private List<string> Validation(TemplateModel model)
        {
            List<string> errors = new List<string>();
            int counter = 0;
            //here we can add some rules
            return errors;
        }
    }
}
