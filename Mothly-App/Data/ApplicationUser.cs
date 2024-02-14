using Microsoft.AspNetCore.Identity;

namespace Mothly_App.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string? ShortName { get; set; }
    }

}
