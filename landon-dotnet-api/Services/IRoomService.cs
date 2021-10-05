using System;
using System.Threading.Tasks;
using landon_dotnet_api.Models;

namespace landon_dotnet_api.Services
{
    public interface IRoomService
    {
        Task<Room> GetRoomAsync(Guid id);
    }
}