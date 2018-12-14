using System;
using System.Collections.Generic;
using System.Text;
using static System.String;
namespace Golden
{
   public class Thing
    {
        public object LastName { get; set; }
        public object FirstName { get; set; }
        public string FullName => $"{FirstName},{LastName}";


        public int Get(int number) => Newtonsoft.Json.JsonConvert.DeserializeObject<int>($"{number}");

        public override string ToString() => $@"{LastName},{FirstName}";

        public object GetProductName()
        {

            return new Thing()?.FirstName ?? "Product1";
        }
    }
}
