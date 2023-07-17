using API.Interfaces;
using AutoMapper;

namespace API.Controllers
{
    public class MessagesController : BaseApiController
    {
        public MessagesController(IUserRepository userRepository, IMessageRepository messageRepository, IMapper mapper)
        {
            
        }
        
    }
}