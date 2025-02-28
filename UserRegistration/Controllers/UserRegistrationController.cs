using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;

namespace UserRegistration.Controllers;

[ApiController]
[Route("[controller]")]
public class UserRegistrationController : ControllerBase
{
    UserRegistrationBL _userRegistrationBL;
    string username = "root";
    string password = "root";

    public UserRegistrationController(UserRegistrationBL userRegistrationBL)
    {
        _userRegistrationBL = userRegistrationBL;
    }

    [HttpGet]
    public string registration()
    {
        return _userRegistrationBL.checkRegistration(username, password);   
    }
}
