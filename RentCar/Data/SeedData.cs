using Microsoft.AspNetCore.Identity;
using RentCar.Areas.Identity.Data;
using System;
using System.Threading.Tasks;

public static class SeedData
{
    public static async Task InitializeAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        // Seed roles
        string[] roleNames = { "Admin", "User" };
        foreach (var roleName in roleNames)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                var role = new IdentityRole { Name = roleName };
                await roleManager.CreateAsync(role);
            }
        }

        // Seed admin user
        var adminEmail = "admin@mail.com";
        var adminUsername = "admin";
        var adminPassword = "123456Aa@";
        var adminFirstName = "Admin";
        var adminLastName = "User";
        var adminEGN = "1234567890";
        var adminAddress = "Admin Address";
        var adminPhoneNumber = "1234567890";

        if (await userManager.FindByEmailAsync(adminEmail) == null)
        {
            var user = new ApplicationUser
            {
                UserName = adminUsername,
                Email = adminEmail,
                FirstName = adminFirstName,
                LastName = adminLastName,
                EGN = adminEGN,
                Address = adminAddress,
                PhoneNumber = adminPhoneNumber
            };

            var result = await userManager.CreateAsync(user, adminPassword);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
