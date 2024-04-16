using AutoMapper;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
              CreateMap<Booking, CreateBookingDto>().ReverseMap();
              CreateMap<Booking, ResultBookingDto>().ReverseMap();
              CreateMap<Booking, UpdateBookingDto>().ReverseMap();
              CreateMap<Booking, GetBookingDto>().ReverseMap();
        }
    }
}
