using LibraryData.Models;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ILibraryAsset //the purpose of this interface is to define any series of methods that will be implemented in the services that use this interface.
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
