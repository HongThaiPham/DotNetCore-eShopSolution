using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Common
{
   public class ApiSuccessedResult<T>: ApiResult<T>
    {
        public ApiSuccessedResult(T resultObj)
        {
            IsSuccessed = true;
            ResultObj = resultObj;
        }

        public ApiSuccessedResult()
        {
            IsSuccessed = true;
        }
    }
}
