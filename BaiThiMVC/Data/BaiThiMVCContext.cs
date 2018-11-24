using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiThiMVC.Models;

namespace BaiThiMVC.Models
{
    public class BaiThiMVCContext : DbContext
    {
        public BaiThiMVCContext (DbContextOptions<BaiThiMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BaiThiMVC.Models.Product> Product { get; set; }

        public DbSet<BaiThiMVC.Models.Category> Category { get; set; }
    }
}
