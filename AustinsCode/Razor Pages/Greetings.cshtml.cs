using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FarmSite2API.Razor_Pages
{
    public class GreetingsModel : PageModel
    {
        public string Message { get; private set; }

        public void OnGet()
        {
            var currentTime = DateTime.Now;
            if (currentTime.Hour < 12)
            {
                Message = "Good morning!";
            }
            else if (currentTime.Hour < 18)
            {
                Message = "Good afternoon!";
            }
            else
            {
                Message = "Good evening!";
            }
        }
    }
}
