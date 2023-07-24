using API.DTOs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Core.DTOS;

namespace API.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
           /* CreateMap<TrainerDTO,Trainer>();
            CreateMap<EmailTrainerCreationDTO,EmailsTrainers>();
            CreateMap<TelefonoTrainerCreationDTO,TelefonosTrainers>();*/
            CreateMap<Trainer,TrainerDTO>().ReverseMap();
            CreateMap<EmailsTrainers,EmailTrainerCreationDTO>().ReverseMap();
            CreateMap<TelefonosTrainers,TelefonoTrainerCreationDTO>().ReverseMap();
            CreateMap<Incidencia,IncidenciaDTO>().ReverseMap();

        }
    }
}