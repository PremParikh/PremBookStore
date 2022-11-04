using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
#pragma warning restore CS0436 // Type conflicts with imported type
            : base(options)
        {
        }
    }
}
