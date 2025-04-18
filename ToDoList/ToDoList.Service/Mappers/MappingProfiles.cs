using AutoMapper;
using ToDoList.Bll.Entities;
using ToDoList.Dal.Entities;

namespace ToDoList.Bll.Mappers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<ToDoListEntity, ToDoListCreateDto>().ReverseMap();
        CreateMap<ToDoListEntity, ToDoListGetDto>().ReverseMap();
    }
}
