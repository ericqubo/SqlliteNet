using SqlliteNetRepositoryTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlliteNetRepositoryTest
{
    public class Context : SqlliteNetMallcoo.SQLiteConnection
    {
        private readonly static string CONNECTION_STRING = "Test.db3";

        public static string DatabaseFilePath()
        {
            return CONNECTION_STRING;
        }
        public Context(string path)
            : base(path)
        {

        }

        public override void OnModelCreating(List<SqlliteNetMallcoo.EntityTypeConfigration> EntityConfigrationList)
        {
            EntityConfigrationList.Add(new SqlliteNetMallcoo.EntityTypeConfigration(typeof(People).FullName).HasKey("id").IsAutoPKInCrease(true).Ignore("age").Ignore("address"));
            EntityConfigrationList.Add(new SqlliteNetMallcoo.EntityTypeConfigration(typeof(School).FullName).HasKey("id").IsAutoPKInCrease(true));
        }
        public override void BatchCreateTables(List<Type> EntityList)
        {
            EntityList.Add(typeof(People));
            EntityList.Add(typeof(School));
        }
    }
}
