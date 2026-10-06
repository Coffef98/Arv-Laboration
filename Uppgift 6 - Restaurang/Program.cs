using RestaurantArv;

McFood fooditemOne = new McFood("Meat Destroyer", 22.50, 770, "Meat", "Large");
McFood fooditemTwo = new McFood("Stinky Fish", 19.99, 440, "Fish", "Medium");

McDrinks drinkitemOne = new McDrinks("Dizzy Liquid", 18.50, 240, "Vodka Beer", true);
McDrinks drinkitemTwo = new McDrinks("Lamey Blamey", 3.30, 0, "Water", false);

fooditemOne.PrintInfo();
drinkitemOne.PrintInfo();

fooditemTwo.PrintInfo();
drinkitemTwo.PrintInfo();

