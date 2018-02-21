using System;
using System.Collections.Generic;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System.Linq;

namespace DataAccess
{
    public class ArtistRepository : IArtistRepository
    {
        private ArtistDbContext _context;
        public ArtistRepository(ArtistDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Artist> GetArtistsDetails()
        {
            var artists = _context.Artists;
            return artists.ToList();
        }

        public bool SaveArtistInfo(Artist artist)
        {
            _context.Entry(artist).State = System.Data.Entity.EntityState.Added;
            _context.SaveChanges();

            return true;
        }
    }
}
