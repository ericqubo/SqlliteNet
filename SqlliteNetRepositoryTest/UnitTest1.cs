using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqlliteNetRepositoryTest.Model;

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
