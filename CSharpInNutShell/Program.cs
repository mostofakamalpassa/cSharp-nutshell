// See https://aka.ms/new-console-template for more information
using CSharpInNutShell.Basic;

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

        Panda panda = new Panda("new panda");

        //Console.WriteLine(panda.Name + " " + Panda.Population);

        TypeConversion typeConversion = new TypeConversion(); ;
        typeConversion.GetTypeOfType();
    }
}