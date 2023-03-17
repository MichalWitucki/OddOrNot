namespace OddOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzi czy wprowadzona przez użytkownika jest parzysta.");
            try
            {

                Console.WriteLine("Podaj liczbę całkowitą");
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                    throw new Exception("Podana wartość nie jest liczbą całkowitą");
                else
                {
                    if (userNumber % 2 == 0)
                        Console.WriteLine("Wprowadzona liczba jest parzysta.");

                    else Console.WriteLine("Liczba nie jest parzysta.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}