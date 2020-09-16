using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokenAuthenticationWEBAPI.DBContext;

namespace TokenAuthenticationWEBAPI.Models
{
    public class UserMasterRepository:IDisposable
    {
        SECURITY_DBEntities context = new SECURITY_DBEntities();
        //This method is used to check and validate the user credentials
        public tblLogin ValidateUser(string username, string password)
        {
            return context.tblLogins.FirstOrDefault(user =>
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.Password == password);
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}