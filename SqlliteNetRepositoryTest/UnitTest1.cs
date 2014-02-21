using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqlliteNetRepositoryTest.Model;
using SqlliteNetMallcoo;

namespace SqlliteNetRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using(UnitOfWork work=new UnitOfWork ()){
                People p = new People()
                {
                    age = 2,
                    address = "111",
                    name = "xiaoming"
                };
                work.peopleRepository().Insert(p);
                work.peopleRepository().Get(t => t.name == "1");
                work.peopleRepository().GetAll(t => t.name == "1").OrderByDescending(t => t.name).ToList();
                
               
               
            }

            using (UnitOfWork work = new UnitOfWork())
            {
                School p = new School()
                {

                    address = "111",
                    name = "xiaoming"
                };
                work.schoolRepository().Insert(p);
            }
        }
    }
}
