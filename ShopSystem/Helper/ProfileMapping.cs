using AutoMapper;
using ShopSystem.DTOS;
using ShopSystem.Models;
using System;

namespace ShopSystem.Helper
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            //Add Team
            CreateMap<AddTeamDTO, Team>();

            //Add Seller
            CreateMap<AddSellerDTO, Seller>();
            CreateMap<TeamInAddSellerDTO, Team>();

            //GET Seller By Id
            CreateMap<Team,TeamInGetSeller>();
            CreateMap<Seller, GetSellerDTO>();

            //Add Customer
            CreateMap<AddCustomerDTO,Customer>();
            CreateMap<CardInCustomerDTO, Card>();

            //GET Customer
            CreateMap<Customer, GetCustomerDTO>();
            CreateMap<Card, CardinGetCustomer>();
            CreateMap<Seller,SellerInGetCustomer >();

            //UpdateCustomer
            CreateMap<UpdateCustomerDTO, Customer>();
            CreateMap<CardInUpdateDTO,Card>();
           
        }
    }
}
