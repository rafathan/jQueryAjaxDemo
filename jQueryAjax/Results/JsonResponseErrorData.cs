using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQueryAjax.Results
{
    public class JsonResponseErrorData
    {

        public string Text;
        public int? Code;

        
        public JsonResponseErrorData(string text, int? code = null)
        {
            this.Text = text;
            this.Code = code;
        }

    }

}