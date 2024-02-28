using Data.Entities;

namespace Laboratorium_6.Models
{
    public interface IAlbumService
    {
        int Add(Album album);
        void Delete(int id);
        void Edit(Album albm);
        List<Album> FindAll();
        Album? FindById(int id);
        List<RecordLabelEntity> FindAllOrganizations();
    }
}
