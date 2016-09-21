using IC.Business;
using IC.Business.DTO;
using IC.DTO;
using IC.Framework.Exception;
using IC.Framework.Logging;
using IC.Framework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace IC.WebApp.Controllers
{
    public class UserAPIController : BaseApiController
    {
        [HttpPost]
        [Route("api/user/RegisterUser/")]
        public HttpResponseMessage RegisterUser([FromBody]UserDTO user)
        {
            try
            {
                OperationResult operationResult = new OperationResult();
                //Business Logic
                var userInfo = (UserDTO)operationResult.Data;
                UserManager jobManager = new UserManager();
                operationResult = new UserManager().RegisterUser(user.Practicetype, user.Project_Code, user.Project_Name, user.Category,
                                    user.Sub_Category, user.Category_ID, user.Sub_Category_ID, user.Header, user.Abstract, user.Detailed_Content,
                                    user.Meta_Tags, user.Tangible_Intangible_Benefits, user.KeyTeam_Involved, user.Comments, user.Status,
                                    user.Pending_With, user.AttachmentPath);

                return this.Request.CreateResponse(HttpStatusCode.OK, operationResult, "text/json");
            }
            catch (SIPException exception)
            {
                LogUtilities.LogException(exception, LogPriorityID.High, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                return this.Request.CreateResponse(HttpStatusCode.OK, exception.Result, "text/json");
            }
            catch (Exception exception)
            {
                LogUtilities.LogException(exception, LogPriorityID.High, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                return this.GetExceptionAsJsonResponse(exception);
            }
        }
        
    }
}
