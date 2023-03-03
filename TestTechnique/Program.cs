namespace TestTechnique
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prix des ingrédients
            double laitPoudrePrix = 0.10;
            double cafePrix = 0.30;
            double chocolatPrix = 0.40;
            double thePrix = 0.30;
            double eauPrix = 0.05;

            // Prix des boissons (avec marge de 30%)
            double espressoPrix = (1 * cafePrix + 2 * eauPrix) * 1.3;
            double laitPrix = (2 * laitPoudrePrix + 1 * eauPrix) * 1.3;
            double capuccinoPrix = (2 * laitPoudrePrix + 1 * eauPrix + 1 * cafePrix + 1 * chocolatPrix) * 1.3;
            double chocolatChaudPrix = (3 * eauPrix + 2 * chocolatPrix) * 1.3;
            double cafeAuLaitPrix = (1 * laitPoudrePrix + 2 * eauPrix + 1 * cafePrix) * 1.3;
            double mokaccinoPrix = (1 * laitPoudrePrix + 2 * eauPrix + 1 * cafePrix + 2 * chocolatPrix) * 1.3;
            double thePrice = (2 * eauPrix + 1 * thePrix) * 1.3;

            // Affichage de la liste des boissons
            Console.WriteLine("Liste des boissons :");
            Console.WriteLine("1. Espresso " );
            Console.WriteLine("2. Lait ");
            Console.WriteLine("3. Capuccino");
            Console.WriteLine("4. Chocolat chaud ");
            Console.WriteLine("5. Café au lait ");
            Console.WriteLine("6. Mokaccino");
            Console.WriteLine("7. Thé " );

            // Demande de choix de boisson à l'utilisateur
            Console.Write("Entrez le numéro de la boisson souhaitée : ");
            int choix = int.Parse(Console.ReadLine());

            // Calcul du prix de la boisson choisie
            double prix = 0;
            switch (choix)
            {
                case 1:
                    prix = espressoPrix;
                    break;
                case 2:
                    prix = laitPrix;
                    break;
                case 3:
                    prix = capuccinoPrix;
                    break;
                case 4:
                    prix = chocolatChaudPrix;
                    break;
                case 5:
                    prix = cafeAuLaitPrix;
                    break;
                case 6:
                    prix = mokaccinoPrix;
                    break;
                case 7:
                    prix = thePrice;
                    break;
                default:
                    Console.WriteLine("Choix invalide.");
                    return;
            }

            // Affichage du prix 
            Console.WriteLine("Prix total : " + prix.ToString("C"));
            
            Console.WriteLine("Merci d'avoir utilisé Distributeur à Café !");


        }
    }
}
