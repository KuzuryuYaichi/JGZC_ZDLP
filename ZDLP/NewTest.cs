using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleJsonTest
{
    class Program
    {
        //static void Main(string[] args)
        //{
 
        //    string jsonText = " {\"companyID\":\"15\",\"employees\":[{\"firstName\":\"Bill\",\"lastName\":\"Gates\"},{\"firstName\":\"George\",\"lastName\":\"Bush\"}],\"manager\":[{\"salary\":\"6000\",\"age\":\"23\"},{\"salary\":\"8000\",\"age\":\"26\"}]} ";
        //    Console.WriteLine(jsonText);
 
        //    RootObject rb = JsonConvert.DeserializeObject<RootObject>(jsonText);
 
        //    Console.WriteLine(rb.companyID);
 
        //    Console.WriteLine(rb.employees[0].firstName);
 
        //    foreach (Manager ep in rb.manager)
        //    {
        //        Console.WriteLine(ep.age);
        //    }
 
        //    Console.ReadKey();
        //}
    }
 
    public class Employees
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
 
    public class Manager
    {
        public string salary { get; set; }
        public string age { get; set; }
    }
 
    public class RootObject
    {
        public string companyID { get; set; }
        public List<Employees> employees { get; set; }
        public List<Manager> manager { get; set; }
    }
}