// See https://aka.ms/new-console-template for more information
using CSharpInNutShell.Basic;
using CSharpInNutShell.Chipter3;

//UnitConverter unitConverter = new UnitConverter(10);
//Console.WriteLine(unitConverter.Convert(12) ); 
//Console.WriteLine(unitConverter.Convert(30) ); 

//Panda panda = new Panda("new panda");

//Console.WriteLine(panda.Name + " " + Panda.Population);

class Program
{
    static void Main() // Program entry point
    {
        //int x = 12 * 30;
        //Console.WriteLine(x);

        //UnitConverter unitConverter = new UnitConverter(10);
        //Console.WriteLine(unitConverter.Convert(12) ); 
        //Console.WriteLine(unitConverter.Convert(30) ); 

        //  Panda panda = new Panda("new panda");

        //Console.WriteLine(panda.Name + " " + Panda.Population);

        //TypeConversion typeConversion = new TypeConversion(); ;
        // typeConversion.GetTypeOfType();

        Rectangle rect = new Rectangle(10.4f, 20.3f);

        (float widht, float height) = rect; // Deconstruction
        // Or
        float width, heightt;
        rect.Deconstruct(out width, out heightt);
        // Or
        rect.Deconstruct(out var widthh, out var heighttt);
        // Or
        (var widthtt, var heightttt) = rect;
        // Or 
        var (width1, height1) = rect;
        // Console.WriteLine(widht + " " + height);

        Bunny bunny = new Bunny { LikeCarrots = true, LikeHumans = true, Name="cart"};

        Bunny bunny1 = new Bunny();
        bunny1.LikeHumans = true;
        bunny1.Name = "jamal";
        bunny1.LikeCarrots = true;

        //Console.WriteLine(bunny.LikeHumans);

        Sentence sentence = new Sentence();
        Console.WriteLine(sentence[3]);
        sentence[3] = "hello kamal";

        Console.WriteLine(sentence[3]);

        /**
         * 
         * A type can declare multiple indexers, each with parameters of different types. 
         * An indexer can also take more than one parameter:
         * 
         * 
         * */

    }
}