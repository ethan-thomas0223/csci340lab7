using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Sport { get; set; }
        [BindProperty(SupportsGet = true)]
        public string TeamSport { get; set; }

        public async Task OnGetAsync()
        {
            var teams = from t in _context.Team
                         select t;
            if (!string.IsNullOrEmpty(SearchString))
            {
                teams = teams.Where(s => s.Name.Contains(SearchString));
            }

            Team = await teams.ToListAsync();
        }
    }
}
