using IC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.Business.DTO
{
    public class UserDTO : BaseDTO
    {
        public int PracticeID__PracticeID__PracticeID { get; set; }
        public string Practicetype { get; set; }
        public string Project_Code { get; set; }
        public string Project_Name { get; set; }
        public string Category { get; set; }
        public string Sub_Category { get; set; }
        public string Category_ID { get; set; }
        public string Sub_Category_ID { get; set; }
        public string Header { get; set; }
        public string Abstract { get; set; }
        public string Detailed_Content { get; set; }
        public string Meta_Tags { get; set; }
        public string Tangible_Intangible_Benefits { get; set; }
        public string KeyTeam_Involved { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
        public string Pending_With { get; set; }
        public string AttachmentPath { get; set; }
    }
}
