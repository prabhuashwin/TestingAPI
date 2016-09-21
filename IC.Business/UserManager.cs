using IC.DataAccess;
using IC.DataAccess.Infrastructure;
using IC.DataModels;
using IC.DTO;
using IC.Framework.Constants;
using IC.Framework.Exception;
using IC.Framework.Logging;
using IC.Framework.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection;

namespace IC.Business
{
    public class UserManager
    {
        public OperationResult RegisterUser(string Practicetype, string Project_Code, string Project_Name, string Category,
                                    string Sub_Category, string Category_ID, string Sub_Category_ID, string Header, string Abstract, string Detailed_Content,
                                    string Meta_Tags, string Tangible_Intangible_Benefits, string KeyTeam_Involved, string Comments, string Status,
                                    string Pending_With, string AttachmentPath)
        {
            try
            {
                bool isSuccess;

                Best_Practice_dt user = default(Best_Practice_dt);

                using (UnitOfWork uow = new UnitOfWork())
                {
                    var userDB = uow.GetDbInterface<UserDB>();
                    isSuccess = userDB.RegisterUser(Practicetype,  Project_Code,  Project_Name,  Category,
                                     Sub_Category,  Category_ID,  Sub_Category_ID,  Header,  Abstract,  Detailed_Content,
                                     Meta_Tags,  Tangible_Intangible_Benefits,  KeyTeam_Involved,  Comments,  Status,
                                     Pending_With,  AttachmentPath);



                }                

                return new OperationResult()
                {
                    Success = true,
                    Message = "User registered successfully",
                    MCode = MessageCode.OperationSuccessful,
                    Data = false
                };
            }
            catch (SIPException exception)
            {
                LogUtilities.LogException(exception, LogPriorityID.High, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                return exception.Result;
            }
            catch (Exception exception)
            {
                LogUtilities.LogException(exception, LogPriorityID.High, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }
        
    }
}
