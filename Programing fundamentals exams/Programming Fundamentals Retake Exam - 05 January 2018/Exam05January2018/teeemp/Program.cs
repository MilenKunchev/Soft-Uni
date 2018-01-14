using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<KeyValuePair<string, string>, int> dictWithKeyValuePair = new Dictionary<KeyValuePair<string, string>, int>();
            // двойката KeyValuePair има  ключ и стойност , ключовете може да са еднакви ако стойностите им са различни и обратно.
            for (int i = 0; i < 6; i++)
            {
                string name = "KeyName";
                string lastName = "ValueName" + i;
                
                KeyValuePair<string, string> testPair = new KeyValuePair<string, string>(name, lastName);

                dictWithKeyValuePair[testPair] = i+3-1;
            }
            // Отпечатване на речника подреден по KeyValuePair по Value в низходящ ред.
            foreach (var item in dictWithKeyValuePair.OrderByDescending(v=>v.Key.Value))
            {
                Console.WriteLine($"{item.Key.Key} --> {item.Key.Value} --> {item.Value}");
            }
            // Сортиране на речника 
            dictWithKeyValuePair = dictWithKeyValuePair.OrderByDescending(v => v.Value).ThenByDescending(k => k.Key.Key).ToDictionary(x => x.Key, y => y.Value);

        }
    }
}
