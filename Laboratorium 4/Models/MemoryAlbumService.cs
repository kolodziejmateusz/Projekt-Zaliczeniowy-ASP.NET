namespace Laboratorium_4.Models
{
    public class MemoryAlbumService : IAlbumService
    {
        private Dictionary<int, Album> _items = new Dictionary<int, Album>();

        public MemoryAlbumService() 
        {
            InitializeSampleData();
        }

        private void InitializeSampleData()
        {
            Add(new Album
            {
                Id = 1,
                Name = "Abbey Road",
                Band = "The Beatles",
                TrackList = "Come Together, Something, Maxwell's Silver Hammer, Oh! Darling, Octopus's Garden, I Want You (She's So Heavy), Here Comes The Sun, Because, You Never Give Me Your Money, Sun King, Mean Mr. Mustard, Polythene Pam, She Came In Through The Bathroom Window, Golden Slumbers, Carry That Weight, The End, Her Majesty.",
                ReleaseDate = new DateTime(1969, 9, 26),
                Duration = "47:23",
                Popularity = Popularity.High
            });

            Add(new Album
            {
                Id = 2,
                Name = "The Dark Side of the Moon",
                Band = "Pink Floyd",
                TrackList = "Speak to Me, Breathe, On the Run, Time, The Great Gig in the Sky, Money, Us and Them, Any Colour You Like, Brain Damage, Eclipse.",
                ReleaseDate = new DateTime(1973, 3, 1),
                Duration = "42:49",
                Popularity = Popularity.TopChart
            });

        }

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

        public void Edit(Album item)
        {
            _items[item.Id] = item;
        }
    }
}
