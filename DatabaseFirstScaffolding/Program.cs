using DatabaseFirstScaffolding;
using Microsoft.EntityFrameworkCore.Design;


using LibraryContext db = new();
void FindByCategory()
{
    Console.WriteLine("Enter category name: ");
    string category = Console.ReadLine();
    var categorydb = db.Categories.FirstOrDefault(c => c.Name.Contains(category));
    int category_id = categorydb.Id;
    foreach (var book in db.Books.Where(b => b.IdCategory == category_id).ToList())
    {
        Console.WriteLine($"---{book.Name}---");
    }
    Console.WriteLine();
    Console.WriteLine();
}
void FindByAuthor()
{
    Console.WriteLine("Enter author name: ");
    string author = Console.ReadLine();
    var authordb = db.Authors.FirstOrDefault(a => a.FirstName.Contains(author) || a.LastName.Contains(author));
    int author_Id = authordb.Id;
    foreach (var book in db.Books.Where(b => b.IdAuthor == author_Id).ToList())
    {
        Console.WriteLine($"---{book.Name}---");
    }
    Console.WriteLine();
    Console.WriteLine();
}
void FindByTheme(){
    Console.WriteLine("Enter Theme:");
    string theme = Console.ReadLine();
    var themedb = db.Themes.FirstOrDefault(t => t.Name.Contains(theme));
    int theme_Id = themedb.Id;
    foreach (var book in db.Books.Where(b => b.IdThemes == theme_Id).ToList())
    {
        Console.WriteLine($"---{book.Name}---");
    }
    Console.WriteLine();
    Console.WriteLine();
}
while (true)
{
    Console.WriteLine("1. Find by Category\n2. Find by Author\n3. Find by Theme");
    switch (Console.ReadLine())
    {
        case "1":
            FindByCategory();
            break;

        case "2":
            FindByAuthor();
            break;
        case "3":
            FindByTheme();
            break;
    }

}