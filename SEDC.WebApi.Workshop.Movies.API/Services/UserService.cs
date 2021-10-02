
using DataAccess.Interfaces;
using Domain.Models;
using DtoModels;
using Services.Interfaces;
using Shared.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public void Create(UserDto entity)
        {
            if (string.IsNullOrEmpty(entity.FullName))
            {
                throw new Exception("name can't be null or empty");
            }
            _repo.Create(entity.ToUser());
        }

        public void Delete(int id)
        {
            if(_repo.GetById(id) == null)
            {
                throw new Exception("user doesn't exist");
            }
            _repo.Delete(id);
        }

        public List<UserDto> GetAll()
        {
            var users = _repo.GetAll().Select(x => x.ToUserDto()).ToList();
            if(users == null)
            {
                throw new Exception("there are currently no users in the database");
            }
            return users;
        }

        public UserDto GetById(int id)
        {
            var user = _repo.GetById(id).ToUserDto();
            if(user == null)
            {
                throw new Exception($"There's no user with id {id}");
            }
            return user;
        }

        public void Update(UserDto entity)
        {
            _repo.Update(entity.ToUser());
        }
        public void WatchMovie(RentAMovieDto dto)
        {
            _repo.WatchMovie(dto.MovieId, dto.UserId);

        }
    }
}
