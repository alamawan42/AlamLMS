using LMS.INFASTRUCTURE.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;


namespace LMS.PRESENTATION.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    
    public class WeatherForecastController : ControllerBase
    {

        public IActionResult Test()
        {
            var service = new EmailService();
            var msg = "Email Sent";
            //var msg = service.SendMail();

            return Ok(msg);
        }
      
    }
}
