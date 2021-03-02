using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCase
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("----NamedParameters----");
            GetCohortDetails("DF002","25","OBL",".NET","C# Advanced Concepts");
            GetCohortDetails(name:"DF002", count:"21", mode:"OBL", track:".NET", currentModule:"C# Advanced Concepts");
            GetCohortDetails(name: "DF002", mode: "OBL", count: "21", track: ".NET", currentModule: "C# Advanced Concepts");
            Console.WriteLine("----OptionalParameters----");
            OrderDetails(sellerName: "ABC", productName: "Laptop");
            OrderDetails(sellerName: "XYZ", productName: "Mobile",quantity:2,isReturnable:false);
            Console.ReadLine();
        }
        public static void GetCohortDetails(string name, string count, string mode, string track, string currentModule)
        {
            Console.WriteLine($"It is {name} with {count} GenCs undergoing training for {track} thru {mode}.\nThe current module of training is {currentModule}\n");
        }
        public static void OrderDetails(string sellerName,string productName,int quantity=1,bool isReturnable=true)
        {
            Console.WriteLine("Here is the order detail – {0} number of {1} by {2} is ordered.\nIt’s returnable status is {3}\n", quantity, productName, sellerName, isReturnable);
        }
        
    }
}
