using Data.Entities;
using Laboratorium_5.Models;

namespace Laboratorium_5.Mappers
{
    public class AlbumMapper
    {
        public static Album FromEntity(AlbumEntity entity)
        {
            if(entity == null)
            {
                return null;
            }
            
            return new Album()
            {
                Id = entity.Id,
                Name = entity.Name,
                Band = entity.Band,
                TrackList = entity.TrackList,
                ReleaseDate = entity.ReleaseDate,
                Duration = entity.Duration,
                Popularity = (Models.Popularity)entity.Popularity,
                Created = entity.Created
            };
        }

        public static AlbumEntity ToEntity (Album model)
        {
            return new AlbumEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Band = model.Band,
                TrackList = model.TrackList,
                ReleaseDate = model.ReleaseDate,
                Duration = model.Duration,
                Popularity = (Data.Entities.Popularity)model.Popularity,
                Created = model.Created
            };
        }
    }
}