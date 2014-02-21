using SqlliteNetRepository;
using SqlliteNetRepositoryTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlliteNetMallcoo;

namespace SqlliteNetRepositoryTest
{
    public class PeopleRepository : EFRepository<People>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="context"></param>
        public PeopleRepository(Context context)
            : base(context)
        {
           
        }
    }
}
