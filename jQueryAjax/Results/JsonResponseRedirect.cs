using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQueryAjax.Results
{
    public class JsonResponseRedirect : JsonResponseBase
    {

        public JsonResponseRedirect(string url)
            : base(false, true, new JsonResponseRedirectData(url))
        {
        }

    }

}