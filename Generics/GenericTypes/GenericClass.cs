using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericTypes
{
    /***
     * In the following example, GenericClass<T,U> requires T to derive from (or be identical to) SomeClass and implement Interface1, and requires U to provide a parameterless constructor
     * 
     * ***/
    public class SomeClass { }
   public interface Interface1 { }
    internal class GenericClass<T,U> where T: SomeClass, Interface1 where U : new()
    {
    }

    /*****
     * You can apply constraints wherever type parameters are defined, in both methods and type definitions. 
     * A base-class constraint specifies that the type parameter must subclass (or match) a particular class; an interface constraint specifies that the type parameter must implement that interface.
     * 
     * These constraints allow instances of the type parameter to be implicitly converted to that class or interface
     * 
     * ***/
}
