using Microsoft.AspNetCore.Identity;

namespace GeekShopping.IdentityServer.Model.Context
{
    public class ApplicationUser : IdentityUser
    {
        private string _firstName { get; set; } 
        private string _lastName { get; set; }  
    }
}
