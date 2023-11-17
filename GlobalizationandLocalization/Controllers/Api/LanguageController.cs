using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace GlobalizationandLocalization.Controllers.Api
{
        [Route("api/[controller]")]
        [ApiController]

    public class LanguageController : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController> _Localizer;

        public LanguageController(IStringLocalizer<LanguageController> localizer)
        {
            _Localizer = localizer;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_Localizer["Welcome"].Value);
        }
    }
}
