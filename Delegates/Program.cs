using Delegates.Delegate;
using Delegates;
public class Program
{

    public static void Main()
    {
        // Assigning a method to a delegate variable creates a delegate instance:
        Transformer trans = new Test().Square; // Create delegate instance

        // You can invoke a delegate instance in the same way as a method:
        trans.Invoke(10);
       int rr =  trans(10); // // Invoke delegate
        Console.WriteLine(rr); // Result  

        // delelegate 
        MyReporter reporter = new MyReporter();
        ProgressReporter progressReporter = reporter.ReportProgress;
        progressReporter.Invoke(33);


        // 

        ProgressReporters p = Util.WriteProgressToConsole;
        p += Util.WriteProgressToFile;
        Util.HardWork(p);

        // Faunction or Func Delegate Return in or out parameters

        Func<String> func = () => "hellow kamal passa";
        Func<Object> func2;

        // Action Delegate 

        Action<string> ac;
        ac = (i) => Console.WriteLine("hello kamal"); ;

        // indexer of delegation 
        Action[] number = new Action[5];

        List<int> list = new List<int>();
        Dictionary<int, string> map = new Dictionary<int, string>();
        HashSet<int> set = new HashSet<int>();
        LinkedList<int> l = new LinkedList<int>(); ;
        IEnumerable<int> l2 = new LinkedList<int>();

        Program pp = new Program();
        IEnumerable<int> l3 = new List<int> { 2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 };
        var iii = pp.EvenNumbersOnly(l3);

        foreach(var x in iii)
        {
            Console.WriteLine(x);
        }



    }

   public IEnumerable<int> Fib(int fibCount)
    {
        for(int i = 0, prevFib = 0, currentFib = 1; i < fibCount; i++)
        {
            yield return prevFib;

            int newFib = prevFib + currentFib;
            prevFib = currentFib;
            currentFib = newFib;
        }
    }

    IEnumerable<string> Foo(bool breakErly)
        {

            yield return "one";
            yield return "two";
            if (breakErly)
            {
                yield break;
            }
            yield return "Three";
        }

         IEnumerable<int> EvenNumbersOnly( IEnumerable<int> numbers)
        {

          foreach(var x in numbers)
            {
                if(x %2  == 0)
                {
                    yield return x;
                }
            }
        }
    
}