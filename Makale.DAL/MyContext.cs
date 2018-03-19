using Makale.Models.IdentityModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makale.DAL
{
    class MyContext : IdentityDbContext<ApplicationUser>
    {
        public MyContext()
       : base("name=MyCon")
        {
        }

    }
}
