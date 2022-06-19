using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersizes.Tasks
{
    internal class youtube
    {
        public delegate void PriceChange(int price);

        public PriceChange PriceChangeHandler { get; set; }

    
        public void Start()
        {
            while (true)
            {
                int bankOfAmericaPrice = (new Random()).Next(100);

                PriceChangeHandler(bankOfAmericaPrice);

                Thread.Sleep(2000);
            }
        }
    }

    class Person 
    {
        public string Name;


        public event Action GotoSleep;
        public event EventHandler Coding;

        public void TakeTime(DateTime now) 
        {
            if(now.Hour <= 8)
            {
                GotoSleep?.Invoke();
            }
            else
            {
                //var args = new EventArgs();
                Coding?.Invoke(this, null);
            }
        }
    }
}
