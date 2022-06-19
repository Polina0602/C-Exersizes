using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersizes.Tasks
{
    internal class Overload
    {
    }

    class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }

        State State1 = new State();
        State State2 = new State();

        public static State operator +(State State1, State State2)
        {

            return new State
            {
                Population = State1.Population + State2.Population,
                Area = State1.Area + State2.Area
            };
                          
        }

        public static bool IsGreeter(State State1, State State2)
        {
            if(State1.Area > State2.Area)
            {
                return true;
            }

            return false;
        }

    }

    // хлеб
    class Bread
    {
        public int Weight { get; set; } // масса
        //public static Sandwich operator +(Bread bread, Butter butter)
        //{
        //    return new Sandwich
        //    {
        //        Weight = bread.Weight + butter.Weight,
        //    };
        //}

    }


    // масло
    class Butter
    {
        public int Weight { get; set; } // масса

        public static Sandwich operator +(Bread bread, Butter butter)
        {
            return new Sandwich
            {
                Weight = bread.Weight + butter.Weight,
            };
        }
    }

    // бутерброт
    class Sandwich
    {
        public int Weight { get; set; } // масса

        //public static Sandwich operator +(Bread bread, Butter butter ) 
        //{
        //    return new Sandwich
        //    {
        //        Weight = bread.Weight + butter.Weight,
        //    };
        //}


    }


}
