using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2IdayatSanni.Controllers
{
    public class MenuController : ApiController
    {
        /// <summary>
        /// calculate the total calories of the meal with the values from the user's choices
        /// </summary>
        /// <param name="burger">the user inputted burger which is an integer</param>
        /// <param name="drink">the user inputted drink which is an integer</param>
        /// <param name="sides">the user inputted sides which is an integer</param>
        /// <param name="dessert">the user inputted dessert which is an integer</param>
        /// <returns>a string showing the calculations of the calories</returns>
        /// <example>
        /// GET api/J1/Menu/4/4/4/4 -> Your total calorie count is 0
        /// GET api/J1/Menu/1/2/3/4 -> Your total calorie count is 691
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            Dictionary<int, int> Burger = new Dictionary<int, int>();
            Burger.Add(1, 461);
            Burger.Add(2, 431);
            Burger.Add(3, 550);
            Burger.Add(4, 0);

            Dictionary<int, int> Drink = new Dictionary<int, int>();
            Drink.Add(1, 130);
            Drink.Add(2, 160);
            Drink.Add(3, 118);
            Drink.Add(4, 0);

            Dictionary<int, int> Sides = new Dictionary<int, int>();
            Sides.Add(1, 100);
            Sides.Add(2, 57);
            Sides.Add(3, 70);
            Sides.Add(4, 0);

            Dictionary<int, int> DessertChoices = new Dictionary<int, int>();
            DessertChoices.Add(1, 100);
            DessertChoices.Add(2, 57);
            DessertChoices.Add(3, 70);
            DessertChoices.Add(4, 0);

            int totalCalories = Burger.ContainsKey(burger) ? Burger[burger] : 0;
            totalCalories += Drink.ContainsKey(drink) ? Drink[drink] : 0;
            totalCalories += Sides.ContainsKey(side) ? Sides[side] : 0;
            totalCalories += DessertChoices.ContainsKey(dessert) ? DessertChoices[dessert] : 0;

            return $"Your total calorie count is {totalCalories}";
            
        }
    }
}
