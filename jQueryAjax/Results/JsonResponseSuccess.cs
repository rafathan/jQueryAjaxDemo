using System.Web.Mvc;

namespace jQueryAjax.Results
{
    public class JsonResponseSuccess : JsonResponseBase
    {

        public JsonResponseSuccess(object data)
            : base(false, false, data)
        {
        }
        public JsonResponseSuccess()
            : this(new object())
        {
        }
    }
}
