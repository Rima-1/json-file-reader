using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApp2
{
    class Program
    {
        private const string path = @"C:\Users\HP\Desktop\JsonFile.json.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Question 5 (a) ---------");
            Console.WriteLine();
            //Parsing Json Lab
            using (StreamReader r = new StreamReader(path))
            {
                string jsonstring = r.ReadToEnd();
                JObject obj1 = JObject.Parse(jsonstring);
                var jsonArrayLabs = JArray.Parse(obj1["labs"].ToString());
                
                //to get first value
                //Console.WriteLine(jsonArray[0]["name"].ToString());
                Dictionary<string, string> dLabs = new Dictionary<string, string>();
                //iterate all values in array
                foreach (var jTokenLabs in jsonArrayLabs)
                {
                    if (jTokenLabs["time"].ToString().Equals("Today"))
                    {
                        dLabs.Add(jTokenLabs["name"].ToString(), jTokenLabs["location"].ToString());
                    }
                }
                foreach (KeyValuePair<string, string> labTemp in dLabs)
                {
                    Console.WriteLine("Name of Lab : {0}, Location of Lab : {1}",
                        labTemp.Key, labTemp.Value);
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Question 5 (b) ---------");
            Console.WriteLine();
            //Deserializing Json
            var fileContent = File.ReadAllText(path);
            dynamic dynObj = JsonConvert.DeserializeObject<dynamic>(fileContent);
            Dictionary<string, string> dMedications = new Dictionary<string, string>();
            foreach (var data in dynObj.medications)
            {
                foreach (var data1 in data.aceInhibitors)
                {
                    if (data1.route.ToString().Equals("PO"))
                        dMedications.Add(data1.name.ToString(), data1.strength.ToString());
                }
                foreach (var data2 in data.antianginal)
                {
                    if (data2.route.ToString().Equals("PO"))
                        dMedications.Add(data2.name.ToString(), data2.strength.ToString());
                }
                foreach (var data3 in data.anticoagulants)
                {
                    if (data3.route.ToString().Equals("PO"))
                        dMedications.Add(data3.name.ToString(), data3.strength.ToString());
                }
                foreach (var data4 in data.betaBlocker)
                {
                    if (data4.route.ToString().Equals("PO"))
                        dMedications.Add(data4.name.ToString(), data4.strength.ToString());
                }
                foreach (var data5 in data.diuretic)
                {
                    if (data5.route.ToString().Equals("PO"))
                        dMedications.Add(data5.name.ToString(), data5.strength.ToString());
                }
                foreach (var data6 in data.mineral)
                {
                    if (data6.route.ToString().Equals("PO"))
                        dMedications.Add(data6.name.ToString(), data6.strength.ToString());
                }
            }
            foreach (KeyValuePair<string, string> medicationTemp in dMedications)
            {
                Console.WriteLine("Name of Medication : {0}, Strength of Medication : {1}",
                    medicationTemp.Key, medicationTemp.Value);
            }
        }
    }
}
