
using DataAccess.Entities;
using System.Collections.Generic;
using System;
using System.Diagnostics.Contracts;

namespace DataAccess.Interfaces
{
    [ContractClass(typeof(ContractClassForArtistRepository))]
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetArtistsDetails();

        bool SaveArtistInfo(Artist artist);
    }

    [ContractClassFor(typeof(IArtistRepository))]
    public abstract class ContractClassForArtistRepository : IArtistRepository
    {
        public IEnumerable<Artist> GetArtistsDetails()
        {
            return default(IEnumerable<Artist>);
        }

        public bool SaveArtistInfo(Artist artist)
        {
            Contract.Requires(artist != null);
            Contract.Requires(!string.IsNullOrEmpty(artist.Name));

            return default(bool);
        }
    }
}
