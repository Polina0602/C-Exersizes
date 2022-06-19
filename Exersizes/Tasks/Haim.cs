using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersizes.Tasks
{
    internal class Haim
    {
        public class buttonPressed
        {
            bool buttonPressedCondition = false;
            public delegate void ButtonPressedDelegate();
            public event ButtonPressedDelegate ButtonPressedEvent;

            public bool buttonPressedMethod()
            {
                buttonPressedCondition = true;
                return buttonPressedCondition;
                ButtonPressedEvent.Invoke();
            }
        }

        public class Operate
        {
            buttonPressed ButtonPressed = new buttonPressed();

            public void Init() 
            {
                ButtonPressed.ButtonPressedEvent += Student.Study;
                ButtonPressed.ButtonPressedEvent += Teacher.GoHome;

                ButtonPressed.buttonPressedMethod();
            }
        }

        public class Student
        {
            public static void Study()
            {
                Console.WriteLine("I am passing the exam!");
            }
        }

        public class Teacher
        {
            public static void GoHome()
            {
                Console.WriteLine("I am go home!");
            }
        }

    }


}
