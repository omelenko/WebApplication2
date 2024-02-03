using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class AddModel : PageModel
    {

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book book { get; set; } = default!;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || book == null)
            {
                return Page();
            }

            Program.Books.Add(book);

            return RedirectToPage("./Books");
        }
    }
}
