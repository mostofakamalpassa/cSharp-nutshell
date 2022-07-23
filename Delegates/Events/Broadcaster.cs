using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Events
{

    /****************
     * 
     * When using delegates, two emergent roles commonly appear: broadcaster and subscriber.
     * 
     * The broadcaster is a type that contains a delegate field. 
     * The broadcaster decides when to broadcast, by invoking the delegate.
     * The subscribers are the method target recipients. A subscriber decides when to start and stop listening by calling += and -= on the broadcaster’s delegate. 
     * A subscriber does not know about, or interfere with, other subscribers.
     * 
     * Events are a language feature that formalizes this pattern.
     * An event is a construct that exposes just the subset of delegate features required for the broadcaster/subscriber model. 
     * The main purpose of events is to prevent subscribers from interfering with one another.
     * 
     * The easiest way to declare an event is to put the event keyword in front of a delegate member:
     * 
     * *****************/

    // Delegate definition
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    internal class Broadcaster
    {
        // Event declaration
        public event PriceChangedHandler PriceChanged;

        /*********
         * 
         * Code within the Broadcaster type has full access to PriceChanged and can treat it as a delegate. Code outside of Broadcaster can perform only += and -= operations on the PriceChanged event.
         * ********/


        /*******
         * 
         * Three things happen under the hood when you declare an event as follows:
         * 
         * public class Broadcaster{ public event PriceChangedHandler PriceChanged; }
         * First, the compiler translates the event declaration into something close to the following:
         * PriceChangedHandler priceChanged; // private delegate
         * public event PriceChangedHandler PriceChanged { 
            add { priceChanged += value; }
            remove { priceChanged -= value; } }
            
         * 
         * The add and remove keywords denote explicit event accessors—which act rather like property accessors. We describe how to write these later.
         * 
         * Second, the compiler looks within the Broadcaster class for references to PriceChanged that
         *  perform operations other than += or -=, and redirects them to the underlying priceChanged delegate field.
         *  
         *  Third, the compiler translates += and -= operations on the event to calls to the event’s add and remove accessors.
         *  Interestingly, this makes the behavior of += and -= unique when applied to events: unlike in other scenarios, it’s not simply a shortcut for + and - followed by an assignment.
         *  
         * ******/
    }
}
