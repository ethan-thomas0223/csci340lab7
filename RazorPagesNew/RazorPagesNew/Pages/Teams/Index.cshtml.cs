using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesNew.Models;
using RazorPagesNew.Data;

namespace RazorPagesNew.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesNew.Data.RazorPagesNewContext _context;

        public IndexModel(RazorPagesNew.Data.RazorPagesNewContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; }

        public async Task OnGetAsync()
        {
            Team = await _context.Team.ToListAsync();
        }
    }
}
