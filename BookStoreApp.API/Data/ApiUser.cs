using Microsoft.AspNetCore.Identity;

namespace BookStoreApp.Blazor.Server.UI.Services.Base.API.Data
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
