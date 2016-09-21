using IC.DataAccess.Interfaces;
using IC.DataModels;
using IC.DTO;
using IC.Framework.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IC.DataAccess
{
    public class UserDB : IUserDB
    {

        private BPDBEntities dbContext;

        /// <summary>
        /// Initializes a new instance of the UserDB class
        /// </summary>
        /// <param name="dbContext">The data base Context</param>
        public UserDB(BPDBEntities dbContext)
        {
            this.dbContext = dbContext;
        }

        public Best_Practice_dt GetUser(string userName)
        {
            try
            {
                //Best_Practice_dt userDetail = this.dbContext.Best_Practice_dt.Where(a => a.EmailId.Equals(userName)).FirstOrDefault();
                return null;
            }
            catch (Exception exception)
            {
                LogUtilities.LogException(exception, LogPriorityID.High, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }        

        public bool RegisterUser(string Practicetype, string Project_Code, string Project_Name, string Category,
                                    string Sub_Category, string Category_ID, string Sub_Category_ID, string Header, string Abstract, string Detailed_Content,
                                    string Meta_Tags, string Tangible_Intangible_Benefits, string KeyTeam_Involved, string Comments, string Status,
                                    string Pending_With, string AttachmentPath)
        {
            try
            {
                Best_Practice_dt userInfoDB = new Best_Practice_dt();
                userInfoDB.Practicetype = Practicetype;
                userInfoDB.Project_Code = Project_Code;
                userInfoDB.Project_Name = Project_Name;
                userInfoDB.Category = Category;
                userInfoDB.Sub_Category = Sub_Category;
                userInfoDB.Category_ID = Category_ID;
                userInfoDB.Sub_Category_ID = Sub_Category_ID;
                userInfoDB.Header = Header;
                userInfoDB.Abstract = Abstract;
                userInfoDB.Detailed_Content = Detailed_Content;
                userInfoDB.Meta_Tags = Meta_Tags;
                userInfoDB.Tangible_Intangible_Benefits = Tangible_Intangible_Benefits;
                userInfoDB.KeyTeam_Involved = KeyTeam_Involved;
                userInfoDB.Status = Status;
                userInfoDB.Pending_With = Pending_With;
                userInfoDB.AttachmentPath = AttachmentPath;

                this.dbContext.Entry(userInfoDB).State = System.Data.Entity.EntityState.Added;
                return this.dbContext.SaveChanges() > 0;
            }
            catch (Exception exception)
            {
                LogUtilities.LogException(exception, LogPriorityID.High, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }
    }
}
