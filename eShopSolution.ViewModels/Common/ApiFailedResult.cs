using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Common
{
    public class ApiFailedResult<T> : ApiResult<T>
    {
        public string[] ValidationErrors { get; set; }
        public ApiFailedResult(string message)
        {
            IsSuccessed = false;
            Message = message;
        }

        public ApiFailedResult(string[] validationErrors)
        {
            IsSuccessed = false;
            ValidationErrors = validationErrors;
        }
    }
}
