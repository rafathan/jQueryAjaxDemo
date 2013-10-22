using System;
using System.Web.Mvc;

namespace jQueryAjax.Results {

    public class JsonResponseBase : JsonResult {

        public JsonResponseBase(bool isError, bool isRedirect, object message)
        {
            IsError = isError;
            IsRedirect = isRedirect;

            if ((message == null)) {
                throw new ArgumentNullException("message");
            }

            Message = message;

            JsonRequestBehavior = JsonRequestBehavior.AllowGet;

            Data = new {IsError = isError, IsRedirect = isRedirect, Message = message};
        }

        public bool IsError { get; set; }
        public bool IsRedirect { get; set; }
        public object Message { get; set; }
    }
}