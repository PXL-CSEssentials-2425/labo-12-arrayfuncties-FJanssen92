internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = new string[10] { "Peter", "Tom", "Piet", "Ahmed", "Benny", "Anna", "Jane", "Ali", "John", "Tom" };
       // Deel1(names);
       // Deel2(names);
        Deel3(names);

    }

    private static void Deel1(string[] names)
    {
        Console.Write("Geef een naam: ");
        string name = Console.ReadLine();

        if (Array.IndexOf(names, name) == -1)
        {
            Console.WriteLine("Naam niet gevonden in array.");

        }
        else
        {
            Console.WriteLine($"De naam {name} komt voor op index/positie {Array.IndexOf(names, name)}");
        }

        Console.ReadKey();

    }

    private static void Deel2(string[] names) {

        Console.Write("Geef een letter: ");
        string key = Console.ReadLine();

        string first = Array.Find(names, name => name.StartsWith(key));
        string[] all = Array.FindAll(names, name => name.ToUpper().StartsWith(key.ToUpper()));

        if (first is not null) //if (first != null)
        {
            Console.WriteLine($"Eerste naam die begint met letter {key}: {first}");
            Console.Write($"Alle namen die beginnen met de letter {key}: {string.Join(',', all)}");

        }

        else
        {
            Console.WriteLine("Letter niet gevonden in array.");
        }

        
        //foreach (string name in all)
        //{
        //    Console.Write(name + ", ");
        //}
        //Console.WriteLine();

        Console.ReadKey();



    }

    private static void Deel3(string[] names) {

        int index = -1;
        int lengte = -1;

        do
        {
            Console.Write("Index: ");
            if (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index > names.Length - 1)
            {
                Console.WriteLine("Ongeldige index");
                index = -1;
            }
        } while (index == -1);

        do
        {
            Console.Write("Lengte: ");
            if (!int.TryParse(Console.ReadLine(), out lengte) || lengte < 1 || lengte > names.Length - index)
            {
                Console.WriteLine("Ongeldige index");
                lengte = -1;
            }
        } while (lengte == -1);



        Console.WriteLine($"Ongesorteerde array: {string.Join(',', names)}");

        Array.Sort(names, index, lengte);
        Console.WriteLine($"Gesorteerde arrat: {string.Join(',', names)}");

    }

}