using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQueryAjax.Results
{
    public class JsonResponseError : JsonResponseBase
    {
        public JsonResponseError(string text, int? code = null)
            : base(true, false, new JsonResponseErrorData(text, code))
        {

        }
    }

}