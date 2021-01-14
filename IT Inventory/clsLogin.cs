using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Inventory
{
    public class clsLogin
    {
        public static bool isAnActiveDirectoryUser(string username, string password)
        {
            try
            {
                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, ("Onerheem")))
                {
                    return pc.ValidateCredentials(username, password);
                }
            }
            catch
            {
                return false;  
            }

            

        }
    }
}
