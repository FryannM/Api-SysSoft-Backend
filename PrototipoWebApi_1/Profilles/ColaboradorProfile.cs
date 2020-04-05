using AutoMapper;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoWebApi_1.Profilles
{
    public class ColaboradorProfile :Profile
    {
        public ColaboradorProfile()
        {
            CreateMap<Colaborador, ColaboradorDto>()
                .ForMember(x => x.Name, src => src.MapFrom(dest => dest.Col_V_Nombre_1 + dest.Col_V_Nombre_2))
                .ForMember(x => x.MidName, src => src.MapFrom(dest => dest.Col_V_Apellido_1 + dest.Col_V_Apellido_2))
                .ForMember(x => x.Sexo,src => src.MapFrom(dest => dest.Col_C_Sexo  == 'M' ? "Masculino": "Femenino"))
                .ForMember(x => x.Fechanacimiendo, src => src.MapFrom( dest => dest.Col_D_Fecha_Nacimiento.ToShortDateString()))
                .ForMember(x=> x.Departamento, src => src.MapFrom(dest => new Departamento {
                    Dep_V_Descripcion = dest.Departamento.FirstOrDefault().Dep_V_Descripcion
                }));


        }
    }
}
