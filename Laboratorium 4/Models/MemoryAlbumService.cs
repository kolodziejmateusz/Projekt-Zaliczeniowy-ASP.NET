namespace Laboratorium_4.Models
{
    public class MemoryAlbumService : IAlbumService
    {
        private Dictionary<int, Album> _items = new Dictionary<int, Album>();

        public int Add(Album item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
            return item.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Album> FindAll()
        {
            return _items.Values.ToList();
        }

        public Album? FindById(int id) 
        {
            return _items[id];
        }

        public void Update(Album item)
        {
            _items[item.Id] = item;
        }
    }
}
