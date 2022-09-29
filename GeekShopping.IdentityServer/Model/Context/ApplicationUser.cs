using Microsoft.AspNetCore.Identity;

namespace GeekShopping.IdentityServer.Model.Context
{
    public class ApplicationUser : IdentityUser
    {
        public string _firstName { get; set; } 
        public string _lastName { get; set; }  
    }
}
