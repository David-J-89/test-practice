using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Services
{
    public class LibraryAssetService : ILibraryAsset
    {
        private readonly LibraryContext _context;

        public LibraryAssetService(LibraryContext context)
        {
            _context = context;
        }

        public void Add(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges();
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets
                  .Include(asset => asset.Status)
                  .Include(asset => asset.Location);
        }

        public string GetAuthorOrDirector(int id)
        {
            throw new NotImplementedException();
        }

        public LibraryAsset GetById(int id)
        {
            return //_context.LibraryAssets
                   //.Include(asset => asset.Status)
                   //.Include(asset => asset.Location)
                GetAll()
                .FirstOrDefault(asset => asset.Id == id);
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            return GetById(id).Location;
            //return _context.LibraryAssets.FirstOrDefault(asset => asset.Id == id).Location;
        }

        public string GetDeweyIndex(int id)
        {
            if (_context.Books.Any(book => book.Id == id))
            {
                return _context.Books
                    .FirstOrDefault(book => book.Id == id).DeweyIndex;
            }
            else return "";
        }

        public string GetIsbn(int id)
        {
            if (_context.Books.Any(a => a.Id == id))
            {
                return _context.Books
                    .FirstOrDefault(a => a.Id == id).ISBN;
            }

            else return "";
        }

        public string GetTitle(int id)
        {
            return _context.LibraryAssets
              .FirstOrDefault(a => a.Id == id)
              .Title;
        }

        public string GetType(int id)
        {
            var book = _context.LibraryAssets.OfType<Book>()
                .Where(b => b.Id == id);
            return book.Any() ? "Book" : "Video";
        }
    }
}
