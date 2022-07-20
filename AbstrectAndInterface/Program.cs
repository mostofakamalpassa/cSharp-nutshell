
using AbstrectAndInterface;

public class Program
{
    public void Main()
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
    }
}