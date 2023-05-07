/*
Lag en app som tildeler en person en random hobby

Skriv navn inn i konsollen,
la en funksjon trekke en tilfeldig hobby - 
og vis dette sammen med navnet i konsollvinduet.

La det være 3-5 forskjellige hobbyer som kan trekkes.
*/


namespace Pensum_sjekk_uke_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn et navn: ");
            randomHobby();
        }

        static void randomHobby()
        {
            string name = Console.ReadLine();
            string[] hobbies = { "strikking", "tegning", "fotografering" };

            Random random = new Random();
            int randomNumber = random.Next(0, hobbies.Length);

            string randomHobbyString = hobbies[randomNumber];
            Console.WriteLine(name + " du fikk " + randomHobbyString + " som hobby!");
        }
    }
}