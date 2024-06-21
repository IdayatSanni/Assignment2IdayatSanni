using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2IdayatSanni.Controllers
{
    public class DiceGameController : ApiController
    {
        /// <summary>
        /// calculates the number of ways we can get the value of 10 when a dice is rolled
        /// </summary>
        /// <param name="m">first side which is an integer</param>
        /// <param name="n">second side which is an integer</param>
        /// <returns>a string showing how many ways to get a sum of 10</returns>
        /// <example>
        /// GET /api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10.
        /// GET /api/J2/DiceGame/12/4 -> There are 4 ways to get the sum 10.
        /// GET /api/J2/DiceGame/3/3 -> There are 0 ways to get the sum 10.
        /// GET /api/J2/DiceGame/5/5 -> There is 1 way to get the sum 10.
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                
                int s = 10 - i;

                
                if (s >= 1 && s <= n)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                return "There are 0 ways to get the sum 10.";
            }
            else if (count == 1)
            {
                return $"There is {count} way to get the sum 10.";
            }
            else
            {
                return $"There are {count} ways to get the sum 10.";
            }



        }
    }
}
