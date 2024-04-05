namespace MenuPlanBL
{
    public class Menus
    {
        public static List<Menu> menus = new List<Menu>();

        public static void Dishes()
        {
            
            Menu menu1 = new Menu();
            menu1.day = "Breakfast";
            menu1.dish = "1 Cup of Rice \n1 Large Egg, \n1 Standard Hotdog";
            menu1.beverage = "Coffee, Tea, Juice(orange juice or apple juice), Milk";
            menu1.preference = "Hotdog (Grilled, Pan-fried, or Boiled) \nEgg (Fried Sunny-side up, Scrambled, or Boiled) Optional with ketchup";
            menu1.nutrition = "Total Nutrition Information (Per Serving) \nCalories: Approximately 420 kcal \nCarbohydrates: Approximately 48g \nProtein: Approximately 16g \nFat: Approximately 18.5g";
            menu1.time = "7:00AM - 8:00AM";
            menus.Add(menu1);

            
            Menu menu2 = new Menu();
            menu2.day = "Lunch";
            menu2.dish = "1 Cup of Rice, 1 Medium-sized Porkchop, 1 Large Egg";
            menu2.beverage = "Water, Tea, Juice(orange juice or apple juice)";
            menu2.preference = "Porkchop with Gravy or Soy Sauce \nEgg (Fried Sunny-side up, Scrambled, or Boiled) Optional with ketchup";
            menu2.nutrition = "Total Nutrition Information (Per Serving) \nCalories: Approximately 520 kcal \nCarbohydrates: Approximately 46g \nProtein: Approximately 40g \nFat: Approximately 19.5g";
            menu2.time = "11:00AM - 12:00PM";
            menus.Add(menu2);

            
            Menu menu3 = new Menu();
            menu3.day = "Dinner";
            menu3.dish = "1 Cup of Rice, 1 Grilled Chicken Breast";
            menu3.beverage = "Water, Sparkling water";
            menu3.preference = "Sauce for chicken (Teriyaki or Gravy)";
            menu3.nutrition = "Total Nutrition Information (Per Serving) \nCalories: Approximately 430 kcal \nCarbohydrates: Approximately 55g \nProtein: Approximately 46g \nFat: Approximately 4.5g";
            menu3.time = "5:00PM - 6:00PM";
            menus.Add(menu3);
        }

        public static void MenuList()
        {
            
            Dishes();

            Console.WriteLine("\nSelect Meal Option:");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    DisplayMenus(menus[0]);
                    break;

                case "2":
                    DisplayMenus(menus[1]);
                    break;

                case "3":
                    DisplayMenus(menus[2]);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        public static void DisplayMenus(Menu menu)
        {
            Console.WriteLine("Selected Meal: " + menu.day);
            Console.WriteLine("Dish: " + menu.dish);
            Console.WriteLine("Beverage: " + menu.beverage);
            Console.WriteLine("Preference: " + menu.preference);
            Console.WriteLine("Nutrition: " + menu.nutrition);
            Console.WriteLine("Time: " + menu.time);
        }
    }
}
