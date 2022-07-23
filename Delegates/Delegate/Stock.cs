using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegate
{
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    internal class Stock
    {
        string symbol;
        decimal price;

        public Stock(string symbol) => this.symbol = symbol;
        public event PriceChangedHandler PriceChanged;

        //public event EventHandler<PriceChangedEventArgs> PriceChanged;
        //protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        //{
        //    PriceChanged?.Invoke(this, e);
        //}
        public event EventHandler PriceChangeds;
        protected virtual void OnPriceChanged(EventArgs e)
        {
            PriceChangeds?.Invoke(this, e);
        }

        //public decimal Price
        //{
        //    get => price;
        //    set
        //    {
        //        if (price == value) return; // Exit if nothing has changed
        //        decimal oldPrice = price;
        //        price = value;
        //        if (PriceChanged != null) // If invocation list not
        //            PriceChanged(oldPrice, price); // empty, fire event.
        //    }
        //}


        public decimal Price
        {
            get => price;
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }


        /*****
         * 
         * If we remove the event keyword from our example so that PriceChanged becomes an ordinary delegate field, our example would give the same results. 
         * However, Stock would be less robust insomuch as subscribers could do the following things to interfere with one another: Replace other subscribers by reassigning PriceChanged (instead of using the += operator). Clear all subscribers (by setting PriceChanged to null). Broadcast to other subscribers by invoking the delegate.
         * 
         * 
         * 
         * ******/


      


    }
}
