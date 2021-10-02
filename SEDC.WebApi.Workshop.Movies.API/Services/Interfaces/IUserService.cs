﻿using DtoModels;
using System.Collections.Generic;


namespace Services.Interfaces
{
    public interface IUserService
    {
        List<UserDto> GetAll();
        UserDto GetById(int id);
        void Delete(int id);
        void Create(UserDto entity);
        void Update(UserDto entity);
        void WatchMovie(RentAMovieDto dto);
    }
}
