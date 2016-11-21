using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Migrations.SeedData
{
    public abstract class DefaultDataCreator<DbContext>
    {
        protected readonly DbContext _context;

        protected DefaultDataCreator(DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateContent();
        }

        protected abstract void CreateContent();

    }
}
