//N. Harrison Wilkins
//10-18-2022
//GitHub Project - RESTURAUNT PICKER
//This project will show a random resturaunt picker that will be easy and simple to use.
//This will also allow the user to choose between three different categories of food
//PEER REVIEW IN README

Console.Clear();

//any variables will be defined here
Random rnd = new Random();
string foodChoice, playAgain;

//below will be our arrays defined here
string[] chineseFoodArray = {"Uncle Yu's", "Mei Mei's", "China Wok", "The Banana Garden", "The Amazing Kitchen", "Panda Express", "Midori", "Golden Eagle Resturaunt", "Fortune Garden", "Ling Nam Express"};
string[] fastFoodArray = {"McDonald's", "Burger King", "Five Guy's Burger and Fries", "Chick Fil-A", "Habit Burger", "Popeye's", "Wing Stop", "Little Caesar's", "Wendy's", "Chipotle"};
string[] mexicanFoodArray = {"La Costa", "Taqueria La Mexicana", "El Pollo Loco", "El Comal Taco Truck", "La Casita", "Tacos Chapala", "La Kositas", "Birrieria Jalisco", "Tacos El Pelon", "Taco Bell"};

//I couldnt get this array of all 30 options to work,     maybe its too many index's in the array??     its not required so it is commented out
//string[] anyFoodArray = {"La Costa", "Taqueria La Mexicana", "El Pollo Loco", "El Comal Taco Truck", "La Casita", "Tacos Chapala", "La Kositas", "Birrieria Jalisco", "Tacos El Pelon", "Taco Bell", "McDonald's", "Burger King", "Five Guy's Burger and Fries", "Chick Fil-A", "Habit Burger", "Popeye's", "Wing Stop", "Little Caesar's", "Wendy's", "Chipotle", "Uncle Yu's", "Mei Mei's", "China Wok", "The Banana Garden", "The Amazing Kitchen", "Panda Express", "Midori", "Golden Eagle Resturaunt", "Fortune Garden", "Ling Nam Express"};

Console.WriteLine("GREETINGS, ENTER \"Y\" TO PROCEED TO RESTURAINT PICKER");
do{
Console.WriteLine("ENTER \"CHINESE FOOD\" \"FAST FOOD\" OR \"MEXICAN FOOD\" TO CHOOSE YOUR CATEGORY.");
Console.WriteLine("YOU CAN ALSO ENTER \"ANY\" TO PICK FROM ALL THREE CATEGORIES!");
foodChoice = Console.ReadLine().ToUpper();

while(foodChoice != "CHINESE FOOD" && foodChoice != "FAST FOOD" && foodChoice != "MEXICAN FOOD")
{
    Console.WriteLine("INVALID... TRY AGAIN!");
    foodChoice = Console.ReadLine().ToUpper();
}
if(foodChoice == "CHINESE FOOD"){
    Console.WriteLine(chineseFoodArray[rnd.Next(0, chineseFoodArray.Length)]);

}
if(foodChoice == "FAST FOOD"){
    Console.WriteLine(fastFoodArray[rnd.Next(0, fastFoodArray.Length)]);

}
if(foodChoice == "MEXICAN FOOD"){
    Console.WriteLine(mexicanFoodArray[rnd.Next(0, mexicanFoodArray.Length)]);

}
// if(foodChoice == "ANY"){
//     Console.WriteLine(anyFoodArray[rnd.Next(0, anyFoodArray.Length)]);
//}

Console.WriteLine("ENTER \"Y\" TO CHOOSE ANOTHER RANDOM RESTURAUNT, OR ENTER ANY KEY TO EXIT.");
playAgain = Console.ReadLine().ToUpper();

}while(playAgain == "Y");
