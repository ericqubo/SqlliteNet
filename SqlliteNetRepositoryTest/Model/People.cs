using SqlliteNetMallcoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlliteNetRepositoryTest.Model
{
    public class People
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
    }
}
