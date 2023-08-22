﻿using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Mappings
{
    public class DomainToDTOPMappingProfile : Profile
    {

        public DomainToDTOPMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
