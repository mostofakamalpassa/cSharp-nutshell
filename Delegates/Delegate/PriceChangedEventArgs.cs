using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegate
{
    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            lastPrice = lastPrice;
            NewPrice = newPrice;

            
        }

        /*****
             * With an EventArgs subclass in place, the next step is to choose or define a
            delegate for the event. There are three rules:
             * 
             * It must have a void return type.
             * 
             * It must accept two arguments: the first of type object, and the second a subclass of EventArgs. The first argument indicates the event broadcaster, and the second argument contains the extra information to convey.
             * 
             * Its name must end with EventHandler.
             * 
             * 
             * The next step is to define an event of the chosen delegate type. Here, we use the generic EventHandler delegate:
             * 
             * ******/

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            if (PriceChanged != null) PriceChanged(this, e);
        }

        /*********
         * 
         * This provides a central point from which subclasses can invoke or override the event (assuming the class is not sealed).
         * 
         * 
         * 
         * 
         * **********/
        void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                Console.WriteLine("Alert, 10% stock price increase!");
        }
    }
}
