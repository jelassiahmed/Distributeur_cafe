namespace TestTechnique
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine machine = new CoffeeMachine(0.3);
            machine.AfficherBoissons();

            Console.Write("Entrez le nom d'une boisson : ");
            string nomBoisson = Console.ReadLine();

            double prix = machine.CalculerPrix(nomBoisson);
            Console.WriteLine("Prix de la boisson : " + prix);

            Console.ReadKey();
        }
    }
}
