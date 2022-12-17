using AutoMapper;

using ToF.WebApi.DataTransferObjects;
using ToF.WebApi.Simulacra.SimulacraTables;

namespace ToF.WebApi.Simulacra;

public class SimulacraMappingProfile : Profile
{
    public SimulacraMappingProfile()
    {
        CreateMap<SimulacraEntity, GetSimulacraDTO>();
        CreateMap<CreateSimulacraDTO, SimulacraEntity>();
        CreateMap<SimulacraEntity, ShortSimulacraDTO>();
        CreateMap<UpdateSimulacraDTO, SimulacraEntity>();
    }
    
    
}