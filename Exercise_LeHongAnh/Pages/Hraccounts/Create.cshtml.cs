using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataAccess.Models;

namespace Exercise_LeHongAnh.Pages.Hraccounts
{
    public class CreateModel : PageModel
    {
        private readonly DataAccess.Models.CandidateManagementContext _context;

        public CreateModel(DataAccess.Models.CandidateManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Hraccount Hraccount { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Hraccounts.Add(Hraccount);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
