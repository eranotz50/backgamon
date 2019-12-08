using System.Web.Http;

namespace Backgamon.Controllers
{
    public class UsersController : ApiController
    {
        public CreateUserResponse CreateUser(CreateUserRequest request) // [FromBody]
        {
            var response = new CreateUserResponse();

            return response;
        }
    }

    public class CreateUserRequest
    {
        public string User { get; set; }

        public string Password { get; set; }
    }

    public class CreateUserResponse
    {
        public string ErrorMessage { get; set; }

        public bool IsOk { get { return string.IsNullOrEmpty(ErrorMessage); } }
    }

}
