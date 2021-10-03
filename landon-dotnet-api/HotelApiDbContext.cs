using Microsoft.EntityFrameworkCore;

namespace landon_dotnet_api
{
    public class HotelApiDbContext : DbContext
    {
        public HotelApiDbContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<RoomEntity> Rooms { get; set; }
    }
}