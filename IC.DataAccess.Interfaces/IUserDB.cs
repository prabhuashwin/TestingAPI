using IC.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.DataAccess.Interfaces
{
    public interface IUserDB
    {
        Best_Practice_dt GetUser(string userName);
    }
}
