﻿using AutoMapper;
using BackAPI_empresa.DTOs;
using BackAPI_empresa.Models;
using System.Globalization;

namespace BackAPI_empresa.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Departamento
            CreateMap<Departamento, DepartamentoDTO>().ReverseMap();
            #endregion

            #region Empleado
            CreateMap<Empleado, EmpleadoDTO>()
                .ForMember(destino =>
                destino.NombreDepartamento,
                opt => opt.MapFrom(origen => origen.IdDepartamentoNavigation.Nombre)
                )
                .ForMember(destino =>
                destino.FechaContrato,
                opt => opt.MapFrom(origen => origen.FechaContrato.Value.ToString("dd/MM/yy"))
            );

            CreateMap<EmpleadoDTO, Empleado>()
                .ForMember(destino =>
                destino.IdDepartamentoNavigation,
                opt => opt.Ignore()
                )
                .ForMember(destino =>
                destino.FechaContrato,
                opt => opt.MapFrom(origen => DateTime.ParseExact(origen.FechaContrato, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                );

            #endregion
        }

    }
}
