namespace MenuPlanBL
{
    public class Plan
    {
        public string name;
        public List<Menu> menus = new List<Menu>();

        public void AddMenu(Menu menu)
        {
            menus.Add(menu);
        }
        
        public  void DisplayMenus(Menu menu)
        {
            Console.WriteLine("You Selected: " +menu.day);
            Console.WriteLine("Dish: " +menu.dish);
            Console.WriteLine("Beverage: " + menu.beverage);
            Console.WriteLine("Preference: " + menu.preference);
            Console.WriteLine("Nutrition: " + menu.nutrition);
            Console.WriteLine("Time: " + menu.time);
        }
    }
}
