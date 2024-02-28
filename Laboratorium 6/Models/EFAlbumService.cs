using Data;
using Data.Entities;
using Laboratorium_6.Mappers;

namespace Laboratorium_6.Models
{
    public class EFAlbumService : IAlbumService
    {
        private AppDbContext _context;

        public EFAlbumService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Album album)
        {
            album.Created = DateTime.Now;
            var e = _context.Albums.Add(AlbumMapper.ToEntity(album));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id) 
        {
            AlbumEntity? find = _context.Albums.Find(id);
            if(find != null)
            {
                _context.Albums.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Album> FindAll()
        {
            return _context.Albums.Select(e => AlbumMapper.FromEntity(e)).ToList();
        }

        public Album? FindById(int id)
        {
            return AlbumMapper.FromEntity(_context.Albums.Find(id));
        }

        public void Edit(Album album)
        {
            _context.Albums.Update(AlbumMapper.ToEntity(album));
            _context.SaveChanges();
        }
    }
}
