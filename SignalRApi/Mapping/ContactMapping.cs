using AutoMapper;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
             CreateMap<Contact, CreateContactDto>().ReverseMap();
             CreateMap<Contact, ResultContactDto>().ReverseMap();
             CreateMap<Contact, UpdateContactDto>().ReverseMap();
             CreateMap<Contact, GetContactDto>().ReverseMap();
        }
    }
}
