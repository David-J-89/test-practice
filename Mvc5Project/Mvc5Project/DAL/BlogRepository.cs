using Mvc5Project.Models;
using System;

namespace Mvc5Project.DAL
{
    public class BlogRepository : IBlogRepository, IDisposable
    {
        private BlogDbContext _context;

        public BlogRepository(BlogDbContext context)
        {
            _context = context;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}