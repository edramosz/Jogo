using AutoMapper;
using CRUD._03_Entidades;
using CRUD._03_Entidades.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateJogoDTO, Jogo>().ReverseMap();
            CreateMap<CreateClienteDTO, Cliente>().ReverseMap();
        }
    }
}
