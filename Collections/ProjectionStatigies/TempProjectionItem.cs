using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ProjectionStatigies
{
    internal class TempProjectionItem
    {
        public string Original; // Original name
        public string Vowelless; // Vowel-stripped name
    }


    public class TempProjectionItemsOnProject
    {

        public void TempProjectQueryExpression()
        {
            string[] names = { "kamal", "jomal", "jamal", "arif" };

            IEnumerable<TempProjectionItem> items = (from n in names
                                                     select new TempProjectionItem
                                                     {
                                                         Original = n,
                                                         Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
                                                     });

            var interMidate = from n in items where n.Vowelless.Length > 2 select n.Original;

            foreach(TempProjectionItem item in items)
            {
                Console.Write(item.Original+ " duplicate "+ item.Vowelless+" | ");
            }

            IEnumerator<string> enumerator = interMidate.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine("orginal "+ enumerator.Current);
            }
        }
    }
}
