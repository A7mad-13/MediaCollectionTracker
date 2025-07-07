using Microsoft.EntityFrameworkCore;
using MediaCollectionTracker.Models;

namespace MediaCollectionTracker.Data
{
    public class MediaContext : DbContext
    {
        public MediaContext(DbContextOptions<MediaContext> options) : base(options) { }

        public DbSet<MediaItem> MediaItems { get; set; }
    }
}
