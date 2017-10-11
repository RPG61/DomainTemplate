using Domain.Models.ViewModels;
using Domain.Services.Database;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IUserService
    {
        Task<UserViewModel> IndexRequest();
    }

    public class UserService :IUserService
    {
        private readonly ApplicationContext _context;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="context"></param>
        public UserService(ApplicationContext context) => _context = context;
        
        public Task<UserViewModel> IndexRequest()
        {
            throw new System.NotImplementedException();
        }
    }
}
