using System;
using System.Collections;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ReadJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var myJsonString = File.ReadAllText("UTIMCO.JSON");
            var jObj = JsonConvert.DeserializeObject<MenuList[]>(myJsonString);
            JsonData myJsonObj = new JsonData(jObj);
            
            foreach (var itm in myJsonObj.Menus)
            {
                Console.WriteLine(myJsonObj.LabelSum(itm.Menu));
            }

            Console.ReadLine();

        }
    }
}
