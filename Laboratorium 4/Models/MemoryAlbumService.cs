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

            Add(new Album
            {
                Id = 3,
                Name = "Nasza Ziemia Eden",
                Band = "Papa Dance",
                TrackList = "Galaktyczny zwiad, Nasz Disneyland, Temat na clip, It's a simple song, Zły omen, Czas szaleństwa, Nietykalni, Ciało i talent..., Skajlajt, Twój ziemski Eden, The End",
                ReleaseDate = new DateTime(1989, 3, 1),
                Duration = "57:03",
                Popularity = Popularity.Moderate
            });

            Add(new Album
            {
                Id = 4,
                Name = "Zawsze Tam, Gdzie Ty",
                Band = "Lady Pank",
                TrackList = "Dopóki da czas, Przerwa w trasie, Co mnie to obchodzi, Jak igła, Nie omijaj mnie, Niedokończona ulica, Nie wpychaj mnie w to dno, Zawsze tam gdzie ty, Zapłacę każdą cenę, Wiara we wroga",
                ReleaseDate = new DateTime(1994, 1, 1), // Zastąp odpowiednią datą wydania
                Duration = "41:27", // Zastąp odpowiednim czasem trwania
                Popularity = Popularity.High
            });

            Add(new Album
            {
                Id = 5,
                Name = "Synchronicity",
                Band = "The Police",
                TrackList = "Synchronicity I, Walking in Your Footsteps, O My God, Mother, Miss Gradenko, Synchronicity II, Every Breath You Take, King of Pain, Wrapped Around Your Finger, Tea in the Sahara",
                ReleaseDate = new DateTime(1983, 6, 17),
                Duration = "44:18",
                Popularity = Popularity.TopChart
            });

            Add(new Album
            {
                Id = 6,
                Name = "Thriller",
                Band = "Michael Jackson",
                TrackList = "Wanna Be Startin' Somethin', Baby Be Mine, The Girl Is Mine, Thriller, Beat It, Billie Jean, Human Nature, P.Y.T. (Pretty Young Thing), The Lady in My Life",
                ReleaseDate = new DateTime(1982, 11, 30),
                Duration = "42:19",
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
