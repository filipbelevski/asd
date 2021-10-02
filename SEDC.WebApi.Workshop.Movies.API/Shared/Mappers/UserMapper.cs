﻿using Domain.Models;
using DtoModels;
using System.Linq;


namespace Shared.Mappers
{
    public static class UserMapper
    {
        public static User ToUser(this UserDto user)
        {
            return new User()
            {
                Id = user.Id,
                FullName = user.FullName,
                Password = user.Password,
                Subscription = user.Subscription,
                UserName = user.UserName
            };
        }
        public static UserDto ToUserDto(this User user)
        {
            return new UserDto()
            {
                Id = user.Id,
                FullName = user.FullName,
                Password = user.Password,
                Subscription = user.Subscription,
                UserName = user.UserName,
                RentedMovies = user.RentedMovies.Select(x => x.Movie.ToMovieDto()).ToList()
            };
        }
    }
}
