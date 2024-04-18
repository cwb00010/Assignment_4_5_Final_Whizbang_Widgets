using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FarmMaxSiteAPI.Data;
using FarmMaxSiteAPI.Entities;

namespace FarmMaxSite.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly FarmMaxSiteAPI.Data.ApplicationDbContext _context;

        public DetailsModel(FarmMaxSiteAPI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id, bool v)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CityID = await _context.Hotel.FirstOrDefaultAsync(m => m.CityID == id);
            if (CityID)
                v)}
            {
                return NotFoundResult();
            }
            else
            {
                CityID = CityID;
            }
            return Page();
        }
    }
}
