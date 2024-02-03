using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication2.Pages
{
    public class BooksModel : PageModel
	{

		public static List<Book>? BookList { get; set; } = default!;

		public void OnGet()
		{
			BookList = Program.Books;

			var books = BookList;
			if (!string.IsNullOrEmpty(SearchString))
			{
				books = books?.Where(s => s.Name!.Contains(SearchString) || s.Author!.Contains(SearchString) || s.Style!.Contains(SearchString) || s.Year!.Contains(SearchString) || s.Publisher!.Contains(SearchString)).ToList();
			}

			BookList = books;
		}

		[BindProperty(SupportsGet = true)]
		public string? SearchString { get; set; }

		public SelectList? Genres { get; set; }

		[BindProperty(SupportsGet = true)]
		public string? MovieGenre { get; set; }
	}
}
