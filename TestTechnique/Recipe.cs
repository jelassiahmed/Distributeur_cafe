namespace TestTechnique;

public class Recipe
{
    public string Name { get; set; }
    public Dictionary<Ingredient, int> Ingredients { get; set; }

    public Recipe(string name, Dictionary<Ingredient, int> ingredients)
    {
        Name = name;
        Ingredients = ingredients;
    }
}