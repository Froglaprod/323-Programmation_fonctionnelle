
string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };
/* 1.1
string x = "x";
List<string> noX = words.Where(w => !w.Contains(x)).ToList();
noX.ForEach(w => Console.WriteLine(w));
*/
/*1.2
List<string> fourOrMore = words.Where(w => w.Length >= 4 ).ToList();
fourOrMore.ForEach(w => Console.WriteLine(w));

//1.3
List<string> averageLength = words.Where(w=> w.Length)
*/
Dictionary<char, double> frequences = new Dictionary<char, double>
        {
            {'a', 8.13},
            {'b', 0.93},
            {'c', 3.15},
            {'d', 3.55},
            {'e', 17.37},
            {'f', 1.06},
            {'g', 1.23},
            {'h', 0.73},
            {'i', 7.09},
            {'j', 0.61},
            {'k', 0.05},
            {'l', 5.34},
            {'m', 3.24},
            {'n', 7.15},
            {'o', 5.27},
            {'p', 3.03},
            {'q', 0.89},
            {'r', 6.46},
            {'s', 7.90},
            {'t', 7.26},
            {'u', 6.24},
            {'v', 1.83},
            {'w', 0.05},
            {'x', 0.43},
            {'y', 0.13},
            {'z', 0.32}
        };

// Exemple d'utilisation
double epsilone(string word)
{
    double epsiValue = frequences.Select(c => c.Value / 100).First();
    frequences.First().;
    return epsiValue;
}
words.Where(word => epsilone(word) >= 0.5).ToList().ForEach(word => Console.WriteLine(word));