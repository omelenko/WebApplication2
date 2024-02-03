using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class EditModel : PageModel
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

            for (int i = 0; i < Program.Books.Count; i++)
            {
                if (Program.Books[i].Name == book.Name) { Program.Books[i] = book; }
            }

            return RedirectToPage("./Books");
        }
    }
}
