﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayManager
{
    public class SeedData
    {
        public static void Seed(UserManager<IdentityUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            
            SeedUsers(userManager);
            SeedRoles(roleManager);

        }
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("admin@gmail.com").Result==null)
            {
                var user = new IdentityUser()
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com"
                };
                var result = userManager.CreateAsync(user,"P@word12").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
           
        }
        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole()
                {
                    Name = "Administrator"
                };
                var result=roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Employee").Result)
            {
                var role = new IdentityRole()
                {
                    Name = "Employee"
                };
                var result=roleManager.CreateAsync(role).Result;
            }
        }
       
    }
}
