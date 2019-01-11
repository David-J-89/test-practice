using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPI.Models;

namespace LibraryAPI.Data
{
    public interface ILibraryAsset
    {
        IEnumerable<LibraryAsset> GetAll(); //return all objects of this type
        LibraryAsset GetById(int id); //get instance of objects by id prop

        void Add(LibraryAsset newAsset); //ability to add new objects of this type to the dataset.
        string GetAuthorOrDirector(int id);
        string GetDeweyIndex(int id);
        string GetType(int id);
        string GetTitle(int id);
        string GetIsbn(int id);

        LibraryBranch GetCurrentLocation(int id);
    }
}
