internal class Program
{
    private static void Main(string[] args)
    {
        var name = "Ewa";
        var sex = "k";
        int age = 33;

        if (age < 30 && sex == "k")
        {
            Console.WriteLine("Kobieta poniżej 30 lat");
        }
        else if (age == 33 && name == "Ewa")
        {
            Console.WriteLine("Ewa, lat 33");
        }
        else if (age <= 18 && sex != "k")
        {
            Console.WriteLine("Niepełnoletni Mężczyzna");
        }
        else 
        {
            Console.WriteLine("Wprowadź prawidłowe dane");
        }
    }
}