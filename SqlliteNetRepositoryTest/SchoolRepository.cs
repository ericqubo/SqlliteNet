using SqlliteNetRepository;
using SqlliteNetRepositoryTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlliteNetRepositoryTest
{
    public class SchoolRepository : EFRepository<School>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="context"></param>
        public SchoolRepository(Context context)
            : base(context)
        {
        }
    }
}
