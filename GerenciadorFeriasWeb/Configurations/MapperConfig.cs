using AutoMapper;
using GerenciadorFeriasWeb.Data;
using GerenciadorFeriasWeb.Models;

namespace GerenciadorFeriasWeb.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
