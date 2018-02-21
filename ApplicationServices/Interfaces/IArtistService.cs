using ApplicationServices.Model;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace ApplicationServices.Interfaces
{
    public interface IArtistService
    {
        IEnumerable<ArtistDto> GetArtistsDetails();

        bool SaveArtistInfo(ArtistDto artist);
    }

    public abstract class ContractClassForIArtistService : IArtistService
    {
        public IEnumerable<ArtistDto> GetArtistsDetails()
        {
            return default(IEnumerable<ArtistDto>);
        }

        public bool SaveArtistInfo(ArtistDto artist)
        {
            Contract.Requires(artist != null);
            Contract.Requires(!string.IsNullOrEmpty(artist.Name));

            return default(bool);
        }
    }
}
