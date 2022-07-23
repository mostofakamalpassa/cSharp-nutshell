using Delegates.Delegate;

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


    }
}