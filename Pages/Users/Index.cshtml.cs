using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesToastmaster.Models;

namespace RazorPagesToastmaster.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesToastmasterContext _context;

        public IndexModel(RazorPagesToastmasterContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
