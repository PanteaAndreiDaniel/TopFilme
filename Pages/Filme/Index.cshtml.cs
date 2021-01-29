using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TopFilme.Data;
using TopFilme.Modele;

namespace TopFilme.Pages.Filme
{
    public class IndexModel : PageModel
    {
        private readonly TopFilme.Data.TopFilmeContext _context;

        public IndexModel(TopFilme.Data.TopFilmeContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; }

        public async Task OnGetAsync()
        {
            Film = await _context.Film.ToListAsync();
        }
    }
}
