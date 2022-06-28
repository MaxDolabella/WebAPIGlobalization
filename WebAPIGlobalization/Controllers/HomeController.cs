using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Globalization;
using WebAPIGlobalization.Resources;

namespace WebAPIGlobalization.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [Route("/")]
    public IActionResult Index([FromServices] IStringLocalizer<Messages> localizer)
    {
        var horaLocal = DateTime.Now;
        var horaZona = TimeZoneInfo.ConvertTime(horaLocal, TimeZoneInfo.FindSystemTimeZoneById(localizer["TimeZone"].Value));


        return Ok(new
        {
            Message = localizer["HelloWorld"].Value,

            Data_Local = horaLocal.ToString(),
            Data_Zona = horaZona.ToString(),
            Data_UTC = horaLocal.ToUniversalTime().ToString(),

            Numero_Decimal= 123456.789.ToString()
        });
    }
}
