/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Resources.Languages
{
    [Route("[language]/[action]")]
    public class LanguageController : Controller
    {
        public IActionResult SetLanguage(string language, string redirectUri)
        {
            if (language != null)
            {
                HttpContext.Response.Cookies.Append(
                    CookieRequestLanguageProvider.DefaultCookieName,
                    CookieRequestLanguageProvider.MakeCookieValue(
                        new RequestLanguage(language)));
            }

            return LocalRedirect(redirectUri);
        }
    }
} */