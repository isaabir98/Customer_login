
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Login.Models
{
    public class DbAuthentication : IdentityDbContext<ApplicationUser>
    {


        public DbAuthentication(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<ApplicationUser>ApplicationUsers{get; set;}
    
    
    }
       

       
}
