using Generics;
using Generics.GenericTypes;

public class Program
{

    static void Main()
    {
        var stack = new Generics.Stack<int>();
        stack.Push(5);
        stack.Push(10);
        int x = stack.Pop(); // x is 10
        int y = stack.Pop(); // y is 5

       //  To instantiate:
            Dictionarys<int, string> myDict = new Dictionarys<int, string>();
      //  Or:
        var myDicts = new Dictionarys<int, string>();
        //Compare<int> com = new Compare<int>();
        Compare<int>.Max<int, int>(5, 10); // 10
                                           // string last = Max("ant", "zoo"); // zoo

    }

}