
using AbstrectAndInterface;
using AbstrectAndInterface.Base;
using AbstrectAndInterface.InterFace;

public class Program
{
    public static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        Overrider over = new Overrider();
        BaseClass b1 = over;
        over.Foo(); // Overrider.Foo
        b1.Foo(); // Overrider.Foo
        Hider h = new Hider();
        BaseClass b2 = h;
        h.Foo(); // Hider.Foo
        b2.Foo(); // BaseClass.Foo

        Stack stack = new Stack();
        stack.Push("sausage");
        string s = (string)stack.Pop(); // Downcast, so explicit cast is needed
        Console.WriteLine(s); // sausage

        stack.Push(3);
        int three = (int)stack.Pop();

        IEnumerators e = new Countdown();

        //while (e.MoveNext())
        //{
        //    Console.WriteLine(e.Current);
        //}

       IEnumerators ee = (IEnumerators)  Util.GetCountDwon();
        Console.WriteLine(ee.MoveNext()); ;

    }
}