namespace TestTechnique;

public class CoffeeMachine
{
    private Dictionary<string, Ingredient> _ingredients;
        private Dictionary<string, Recipe> _recipes;
        private double _marge;

        public CoffeeMachine(double marge)
        {
            _ingredients = new Dictionary<string, Ingredient>
            {
                { "lait en poudre", new Ingredient("lait en poudre", (decimal)0.10) },
                { "café", new Ingredient("café", (decimal)0.30) },
                { "chocolat", new Ingredient("chocolat", (decimal)0.40) },
                { "thé", new Ingredient("thé", (decimal)0.30) },
                { "eau", new Ingredient("eau", (decimal)0.05) }
            };

            _recipes = new Dictionary<string, Recipe>
            {
                { "Espresso", new Recipe("Espresso", new Dictionary<Ingredient, int> { { _ingredients["café"], 1 }, { _ingredients["eau"], 2 } }) },
                { "Lait", new Recipe("Lait", new Dictionary<Ingredient, int> { { _ingredients["lait en poudre"], 2 }, { _ingredients["eau"], 1 } }) },
                { "Cappuccino", new Recipe("Cappuccino", new Dictionary<Ingredient, int> { { _ingredients["lait en poudre"], 2 }, { _ingredients["eau"], 1 }, { _ingredients["café"], 1 }, { _ingredients["chocolat"], 1 } }) },
                { "Chocolat Chaud", new Recipe("Chocolat Chaud", new Dictionary<Ingredient, int> { { _ingredients["eau"], 3 }, { _ingredients["chocolat"], 2 } }) },
                { "Café au Lait", new Recipe("Café au Lait", new Dictionary<Ingredient, int> { { _ingredients["lait en poudre"], 1 }, { _ingredients["eau"], 2 }, { _ingredients["café"], 1 } }) },
                { "Mokaccino", new Recipe("Mokaccino", new Dictionary<Ingredient, int> { { _ingredients["lait en poudre"], 1 }, { _ingredients["eau"], 2 }, { _ingredients["café"], 1 }, { _ingredients["chocolat"], 2 } }) },
                { "Thé", new Recipe("Thé", new Dictionary<Ingredient, int> { { _ingredients["thé"], 1 }, { _ingredients["eau"], 2 } }) }
            };

            _marge = marge;
        }

        public void AfficherBoissons()
        {
            Console.WriteLine("Boissons disponibles :");
            foreach (var recipe in _recipes)
            {
                Console.WriteLine("- " + recipe.Value.Name);
            }
        }
        
        public double CalculerPrix(string nomBoisson)
        {
            if (!_recipes.ContainsKey(nomBoisson))
            {
                Console.WriteLine("Boisson inexistante.");
                return 0;
            }

            double prix = 0;
            Recipe recette = _recipes[nomBoisson];
            foreach (var ingredient in recette.Ingredients)
            {
                prix += (double)(ingredient.Key.Price * ingredient.Value);
            }

            prix *= (1 + _marge);

            return prix;
        }
}
