using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_RAZOR_CONTOSO.Data;
using ASP_RAZOR_CONTOSO.Models;

namespace ASP_RAZOR_CONTOSO.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly ASP_RAZOR_CONTOSO.Data.ApplicationDbContext _context;

        public DetailsModel(ASP_RAZOR_CONTOSO.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students.FirstOrDefaultAsync(m => m.StudentID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
