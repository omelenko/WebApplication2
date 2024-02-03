using System.Xml.Linq;
using WebApplication2;

internal class Program
{
    public static List<Book>? Books;

	private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        Books = new List<Book>()
        {
            new Book()
			{
			Name = "The Catcher in the Rye",
			Author = "J.D. Salinger",
			Style = "Fiction",
			Publisher = "Little, Brown and Company",
			Year = "1951"
			},
            new Book()
			{
			Name = "To Kill a Mockingbird",
			Author = "Harper Lee",
			Style = "Fiction",
			Publisher = "J.B. Lippincott & Co.",
			Year = "1960"
			},
            new Book()
			{
			Name = "1984",
			Author = "George Orwell",
			Style = "Dystopian Fiction",
			Publisher = "Secker & Warburg",
			Year = "1949"
			}
        };
        // Add services to the container.
        builder.Services.AddRazorPages();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
    }
}