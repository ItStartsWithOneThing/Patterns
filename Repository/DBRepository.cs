using System;
using System.Collections.Generic;

namespace Repository
{
    public class DBRepository : IRepository<Laptop>
    {
        // private LaptopDbContext context;

        /*
         public DBRepository(LaptopDbContext _context)
        {
            this.context = _context;
        }
        */

        public void Create(Laptop item)
        {
            // Creating
        }

        public void Delete(int id)
        {
            // Removing
        }

        public Laptop GetBook(int id)
        {
            // Getting

            return null;
        }

        public IEnumerable<Laptop> GetBookList()
        {
            // Getting

            return null;
        }

        public void Save()
        {
            // Saving
        }

        public void Update(Laptop item)
        {
            // Replacing
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                   // context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
