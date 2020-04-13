using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private UdemyDbContext context = null;
        public AccountModel()
        {
            context = new UdemyDbContext();
        }
        public bool Login(string userName, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter ("@UserName", userName),
                new SqlParameter("@PassWord", password),
            };
            var res = context.Database.SqlQuery<bool>("account_login @UserName , @PassWord", sqlParams).SingleOrDefault();
            return res;
        }

    }
}
