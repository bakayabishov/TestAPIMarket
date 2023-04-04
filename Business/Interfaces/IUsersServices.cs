using TestAPIMarket.Business.Models;

namespace TestAPIMarket.Business.Interfaces;

public interface IUsersServices
{
    Task AddUsersAsync(UserDto user);
}