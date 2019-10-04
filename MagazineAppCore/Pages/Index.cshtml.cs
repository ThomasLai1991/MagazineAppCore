using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MagazineAppContext.Models;
using MagazineAppContext;

namespace MagazineAppCore.Pages
{
    public class IndexModel : PageModel
    {
        public MagazineAppContext.Context _context;

        public IndexModel(MagazineAppContext.Context Context)
        {
            _context = Context;
        }


        public void OnGet(int resultPerPage = 50, int pageNumber = 1, int UserID = 1, int MagazineID = 1, string SearchText = "")
        {


 


        }
    }
}
