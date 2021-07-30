using System;
using System.Collections.Generic;
using System.Text;

namespace Crudemo.Business.Responses
{
    public abstract class ResponseBase
    {
        public bool IsSuccessful { get; set; }
        public string Error { get; set; }
    }
}
