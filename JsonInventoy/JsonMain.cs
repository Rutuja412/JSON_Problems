using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

namespace JsonInventoy
{
    internal class JsonMain
    {
        Model Inventory = new Model();
        List<Model> InventoryList = new List<Model>();
        public void convert(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Model>>(json);
                // Console.WriteLine("Name Weight Price TotalValue");
                Console.WriteLine("StockName NumOfShare SharePrice TotalValueOfStock");
                foreach (var item in items)
                {
                    double value = item.SharePrice * item.NumOfShare;
                    Console.WriteLine(item.StockName + " " + item.NumOfShare + " " + item.SharePrice + " " + value);
                }
            }
    }  }
}
