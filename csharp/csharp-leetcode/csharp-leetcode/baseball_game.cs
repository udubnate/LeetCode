using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_leetcode
{

    // https://leetcode.com/problems/baseball-game/
    // Note I used List, in reviewing the solutions Stack would have been probably a better data structure
    // due to the fact you are accessing last element a bunch
    public class baseball_game
    {
        public int CalPoints(string[] ops)
        {
            //generate output list
            List<int> points = new List<int>();
            //parse string
            for (int i = 0; i < ops.Length; i++)
            {
                switch (ops[i])
                {
                    case "D":
                        points.Add(points[points.Count - 1] * 2); 
                        break;
                    case "C": 
                        points.RemoveAt(points.Count-1); 
                        break;
                    case "+": 
                        var newScore = points[points.Count - 1] + points[points.Count - 2];
                        points.Add(newScore);
                        break;
                    default:
                        points.Add(Int32.Parse(ops[i])); 
                        break;
                }
            }

            return points.Sum();
        }
    }
}
