using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class DeleteModel : PageModel
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

			foreach (var e in Program.Books)
			{
				if(e.Name == book.Name)
				{
                    Program.Books.Remove(e);
					break;
                }
			}

			return RedirectToPage("./Books");
		}
	}
}
