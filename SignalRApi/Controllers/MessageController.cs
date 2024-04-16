using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            Message message = new Message()
            {
                NameSurname = createMessageDto.NameSurname,
                Mail = createMessageDto.Mail,
                Phone = createMessageDto.Phone,
                Subject = createMessageDto.Subject,
                MessageContent = createMessageDto.MessageContent,
                MessageSendDate = DateTime.Now,
                Status = false
            };
            _messageService.TAdd(message);
            return Ok("Mesaj başarılı bir şekilde eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var values = _messageService.TGetById(id);
            _messageService.TDelete(values);
            return Ok("Mesaj Silindi");
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            Message message = new Message()
            {
                NameSurname = updateMessageDto.NameSurname,
                Mail = updateMessageDto.Mail,
                Phone = updateMessageDto.Phone,
                Subject = updateMessageDto.Subject,
                MessageContent = updateMessageDto.MessageContent,
                MessageSendDate = updateMessageDto.MessageSendDate,
                Status = updateMessageDto.Status,
                MessageID = updateMessageDto.MessageID
            };
            _messageService.TUpdate(message);
            return Ok("Mesaj Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageService.TGetById(id);
            return Ok(value);
        }
    }
}
