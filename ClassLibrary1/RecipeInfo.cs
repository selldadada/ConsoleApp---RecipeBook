using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook
{
    public class RecipeInfo
    {
        public string name;
        List<Program> programs = new List<Program>();

        public void AddDish(Program program)
        {
            programs.Add(program);
        }

        public void SearchProgram(string mainingredient)
        {
            foreach (Program program in programs)
            {
                if (program.ingredients.Contains(mainingredient))
                {
                    Console.WriteLine("DISH FOUND...");
                    DisplayDishInfo(program);
                }
            }
        }

        public void DisplayDishInfo(Program program)
        {
            Console.WriteLine("DISH INFORMATION in " + name + "...");
            Console.WriteLine("\r\nTITLE: " + program.name);
            Console.WriteLine("\r\nDESCRIPTION: " + program.description);
            Console.WriteLine("\r\nINGREDIENTS: " + program.ingredients);
            Console.WriteLine("\r\nHOW TO MAKE: " + program.howtomake);
            Console.WriteLine("-------------------");
        }

        public void DeleteProgram(Program program)
        {
            programs.Remove(program);
        }
    }
}
