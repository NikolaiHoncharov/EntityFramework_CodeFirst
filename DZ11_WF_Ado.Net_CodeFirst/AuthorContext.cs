using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ11_WF_Ado.Net_CodeFirst
{
    class AuthorContext : DbContext
    {
        public AuthorContext() : base()
        {

        }

        public DbSet<Author> Authors { get; set; }

    }
}
