﻿using Newtonsoft.Json;
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
                Console.WriteLine("Name Weight Price TotalValue");
                foreach (var item in items)
                {
                    double value = item.Price * item.Weight;
                    Console.WriteLine(item.Name + " " + item.Weight + " " + item.Price + " " + value);
                }
            }
    }  }
}
