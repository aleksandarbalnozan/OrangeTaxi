using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UberWannBe.Data.Entity;
using UberWannBe.Dtos.User;

namespace UberWannBe.Profiles
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            // Source => target
            CreateMap<User, UserReadDto>();

            // Target => source
            CreateMap<UserCreateDto, User>();
        }
    }
}
