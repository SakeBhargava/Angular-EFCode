using ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using DataAccess.Interfaces;
using System.Diagnostics.Contracts;
using System.Linq;
using ApplicationServices.Mappers;
using ApplicationServices.Model;

namespace ApplicationServices
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        public ArtistService(IArtistRepository artistRepository)
        {
            Contract.Requires(artistRepository != null);

            _artistRepository = artistRepository;
        }
        public IEnumerable<ArtistDto> GetArtistsDetails()
        {
            var artists = _artistRepository.GetArtistsDetails();
            return artists.Select(s => ArtistAutoMapper.ConvertToArtistDto(s)).ToList();
        }

        public bool SaveArtistInfo(ArtistDto artist)
        {
            return _artistRepository.SaveArtistInfo(ArtistAutoMapper.ConvertToArtist(artist));
        }
    }
}
