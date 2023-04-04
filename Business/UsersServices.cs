using AutoMapper;
using TestAPIMarket.Business.Interfaces;
using TestAPIMarket.Business.Models;
using TestAPIMarket.Data.Entities;
using TestAPIMarket.Data.Repositories.Interfaces;

namespace TestAPIMarket.Business;

public class UsersServices : IUsersServices
{
    private readonly IUsersRepository _usersRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;


    public UsersServices(IUsersRepository usersRepository, IMapper mapper, IUnitOfWork uow)
    {
        _usersRepository = usersRepository;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task AddUsersAsync(UserDto user)
    {
        await _usersRepository.InsertAsync(_mapper.Map<User>(user));
        await _uow.SaveChangesAsync();
    }
}