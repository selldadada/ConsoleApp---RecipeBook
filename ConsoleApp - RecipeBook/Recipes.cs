using System;
using RecipeBook;

namespace RecipeBook
{
    internal class Recipes
    {
        static void Main(string[] args)
        {
            RecipeInfo FamousFilipinoDishes = new RecipeInfo();
            FamousFilipinoDishes.name = "Famous Filipino Dishes..";

            Program top1Dish = new Program();
            top1Dish.name = "Chicken Adobo";
            top1Dish.description = "\r\nChicken adobo is a traditional Filipino dish made by marinated chicken pieces cooked in a mixture of soy sauce, vinegar, garlic, bay leaves, and black peppercorns. The chicken is simmered until tender, allowing the flavors\r\n" +
                "to meld together, resulting in a savory, slightly tangy, and aromatic dish. It's often served with rice and enjoyed as a hearty and comforting meal.";
            top1Dish.ingredients = "\r\n2 tbsp canola oil\r\n6 cloves garlic crushed\r\n1 pc onion, sliced\r\n1 kilogram chicken cut ups\r\n2 tbsp vinegar\r\n1/4 cup soy sauce" +
                "\r\n1 cup water\r\n2 pcs bay leaves\r\n1 tsp whole black peppercorns, slightly crushed\r\n2 pc Knorr chicken cubes\r\n1 tsp brown sugar packed" +
                "\r\nOption: 1 cup kale or spinach";
            top1Dish.howtomake = "\r\n1. Heat oil in pan and sauté garlic and onions. Then add chicken to the pan and sear on all sides, until you have a little browning in the chicken skin." +
                "\r\n2. Pour in vinegar, soy sauce and water. Add bay leaves, pepper and Knorr Chicken Cubes. Bring to a boil over high heat then reduce heat to simmer, but do not " +
                "cover the pan. Continue to simmer for 10 mins.\r\n3. Remove chicken pieces from sauce and fry in another pan until nicely browned.\r\n4. Put back fried chicken " +
                "pieces into sauce. Add sugar and let simmer again for another 10 minutes or until sauce has thickened. Serve warm.\r\n\r\n";

            Program top2Dish = new Program();
            {
                top2Dish.name = "Pork Sinigang";
                top2Dish.description = "\r\nPork sinigang is a popular Filipino soup known for its sour and savory flavor profile. It features tender pork pieces simmered in a tamarind-based" +
                    " broth along with various vegetables such as kangkong (water spinach), radish, eggplant, \r\nand string beans. The broth is typically flavored with tomatoes, onions," +
                    " and" + " fish sauce, creating a deliciously tangy and hearty dish that is commonly enjoyed with steamed rice.";
                top2Dish.ingredients = "\r\nPork\r\nTomatoes\r\nOnion\r\nFish sauce\r\nGabi\r\nRadish\r\nVegetables\r\nTamarind\r\nBanana or finger chili peppers";
                top2Dish.howtomake = "\r\n1. Wash tamarind pods under cold, running water to remove any grit or dirt from the skins.\r\n2. Place in a saucepan with about 1 cup water and bring to" +
                    " a boil. Cook for about 4 to 5 minutes until soft, and the outer skins begin to burst.\r\n3. Using a fork, mash the tamarinds to release the pulp.\r\n4. Place the " +
                    "tamarind and liquid in a fine-mesh strainer set over a bowl. Continue to mash with a fork, returning some of the liquid into the strainer once or twice to fully " +
                    "extract the juice.\r\n5. Discard seeds and skins. Pour tamarind juice into the pot.\r\n";
            };

            FamousFilipinoDishes.AddDish(top1Dish);
            FamousFilipinoDishes.AddDish(top2Dish);

            FamousFilipinoDishes.SearchProgram("chicken");
            FamousFilipinoDishes.DisplayDishInfo(top2Dish);
        }
    }
}