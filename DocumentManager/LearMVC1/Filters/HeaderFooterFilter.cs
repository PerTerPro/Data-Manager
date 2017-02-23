using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearMVC1.ViewModel;

namespace LearMVC1.Filters
{
    public class HeaderFooterFilter:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ViewResult v = filterContext.Result as ViewResult;
            if (v != null)  //v is null when v is not a ViewResult
            {
                BaseViewModel bvm = v.Model as BaseViewModel;
                if (bvm != null)
                {
                    bvm.UserName = HttpContext.Current.User.Identity.Name;
                    bvm.FooterData = new FooterViewModel()
                    {
                        CompanyName = "StepByStepSchools",
                        Year = DateTime.Now.ToString("yyyy MMMM dd mm-ss")
                    };
                }
            }
        }
    }
}