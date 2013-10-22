using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using jQueryAjax.FakeDataService;
using jQueryAjax.FakeRepo;
using jQueryAjax.Results;

namespace jQueryAjax.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Index()
        {
            List<Person> people = Service.GetPeople();
            return View(people);
        }

        public ActionResult Add(Person newGuy)
        {
            try
            {
                newGuy.ID = Service.GetNextID();
                var model = Service.AddPerson(newGuy);
                string view = RenderViewToString("_thePeople", model);
                
                return new JsonResponseSuccess(view);
               
            }
            catch (Exception ex)
            {
                return new JsonResponseError(ex.Message);
            }
        }

        public ActionResult Remove(int id)
        {
            try
            {
                var model = Service.RemovePerson(id);
                string view = RenderViewToString("_thePeople", model);

                return new JsonResponseSuccess(view);
            }
            catch (Exception ex)
            {
                return new JsonResponseError(ex.Message);
            }
        }

        #region Helper Methods

        public string RenderViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }

        #endregion

    }
}