using Microsoft.AspNetCore.Identity;
using Cinema.Models;

namespace Cinema.Data
{
    public class DbSeeder
    {
        public static async Task SendRolesAndAdminAsync(IServiceProvider service)
        {
            //Seed Roles
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Cashier.ToString()));

            //creating admin
            var user = new ApplicationUser
            {
                UserName="admin@gmail.com",
                Email="admin@gmail.com",
                Name="Pavkata",
                EmailConfirmed=true,
                PhoneNumberConfirmed=true,
            };

            var userIndDb=await userManager.FindByEmailAsync(user.Email);
            if (userIndDb==null)
            {
                await userManager.CreateAsync(user, "Admin@123");
                await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
            }
        }
    }
}
