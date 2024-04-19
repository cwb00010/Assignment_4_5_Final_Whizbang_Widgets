using System.Threading.Tasks;
using FarmSite2API.Entities;
using FarmSite2API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FarmSite2.Pages
{
    public class AddCityModel : PageModel
    {
        [BindProperty]
        public City City { get; set; }

        [TempData]
        public string Message { get; set; }

        private readonly CityService _cityService;

        public AddCityModel(CityService cityService)
        {
            _cityService = cityService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Message = await _cityService.AddCity(City);

            return RedirectToPage();
        }
    }
}
