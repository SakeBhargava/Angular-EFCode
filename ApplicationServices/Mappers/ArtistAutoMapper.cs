using ApplicationServices.Model;
using AutoMapper;
using DataAccess.Entities;

namespace ApplicationServices.Mappers
{
    public static class ArtistAutoMapper
    {
        public static void Initialize()
        {
            Mapper.Initialize(
                map =>
                {
                    map.CreateMap<Artist, ArtistDto>();
                    map.CreateMap<ArtistDto, Artist>();
                });
        }

        public static Artist ConvertToArtist(ArtistDto artist)
        {
            return Mapper.Map<ArtistDto, Artist>(artist);
        }

        public static ArtistDto ConvertToArtistDto(Artist artist)
        {
            return Mapper.Map<Artist, ArtistDto>(artist);
        }
    }
}
