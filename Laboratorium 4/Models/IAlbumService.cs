namespace Laboratorium_4.Models
{
    public interface IAlbumService
    {
        int Add(Album album);
        void Delete(int id);
        void Update(Album albm);
        List<Album> FindAll();
        Album? FindById(int id);
    }
}
