using PMS.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PMS.API.Controllers
{
    public class BaseController : ApiController
    {
        protected HttpResponseMessage BuildResponse<T>(T resultValue)
        {
            var propertyValue = resultValue.GetType().GetProperty("Code")?.GetValue(resultValue);
            var responseCode = (ResponseCodes)Enum.Parse(typeof(ResponseCodes), propertyValue?.ToString());
            var httpStatusCode = EnumManager.Instance.GetAttributeValue<ResponseCodes, HttpStatusAttribute, HttpStatusCode>(responseCode);
            return Request.CreateResponse(httpStatusCode, resultValue);
        }
    }
}
