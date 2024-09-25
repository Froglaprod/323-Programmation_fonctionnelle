using exoCine;
List<Movie> frenchMovies = new List<Movie>() {
new Movie() { Title = "Le fabuleux destin d'Amélie Poulain", Genre = "Comédie", Rating = 8.3, Year = 2001, LanguageOptions = new string[] {"Français", "English"}, StreamingPlatforms = new string[] {"Netflix", "Hulu"} },
new Movie() { Title = "Intouchables", Genre = "Comédie", Rating = 8.5, Year = 2011, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix", "Amazon"} },
new Movie() { Title = "The Matrix", Genre = "Science-Fiction", Rating = 8.7, Year = 1999, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"} },
new Movie() { Title = "La Vie est belle", Genre = "Drame", Rating = 8.6, Year = 1946, LanguageOptions = new string[] {"Français", "Italiano"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Gran Torino", Genre = "Drame", Rating = 8.2, Year = 2008, LanguageOptions = new string[] {"English"}, StreamingPlatforms = new string[] {"Hulu"} },
new Movie() { Title = "La Haine", Genre = "Drame", Rating = 8.1, Year = 1995, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Oldboy", Genre = "Thriller", Rating = 6.0, Year = 1999, LanguageOptions = new string[] {"Coréen", "English"}, StreamingPlatforms = new string[] {"Amazon"} }

};
double useRating;
int useYear;
string isNotInStreamingOn;
string hasNotLanguage;
string isNotGenreOf1;
string isNotGenreOf2;
void askUser()
{
    Console.WriteLine("Quelle genre de film ne voulez-vous pas voir ?");
    Console.Write("Genre 1 : ");
    isNotGenreOf1 = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Genre 2 : ");
    isNotGenreOf2 = Console.ReadLine();
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("Rating maximum ? ");
    useRating = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Année maximum ? ");
    useYear = Convert.ToInt32(Console.ReadLine());
}
askUser();

List<Movie> filteredMovies = frenchMovies.
    Where(m => (m.Genre != isNotGenreOf1 && m.Genre != isNotGenreOf2)
    && (m.Rating < 7)
    && (m.Year < 2000)
    && (!m.LanguageOptions.Contains("Français"))
    && (!m.StreamingPlatforms.Contains("Netflix")))
    .ToList();
filteredMovies.ForEach(f => Console.WriteLine(f.Title));