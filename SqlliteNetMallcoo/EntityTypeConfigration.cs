using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlliteNetMallcoo
{
    public class EntityTypeConfigration
    {
        internal string FullName { get; private set; }

        internal string PK { get; set; }

        internal bool IsAutoPK { get; set; }
        /// <summary>
        /// 忽略掉的字段
        /// </summary>
        internal List<string> IgnoreList { get; set; }

        /// <summary>
        ///构造函数
        /// </summary>
        /// <param name="FullName">type 的完全限定名</param>
        public EntityTypeConfigration(string FullName)
        {
            this.FullName = FullName;
            IgnoreList = new List<string>();
        }

        /// <summary>
        /// 设置主键
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public EntityTypeConfigration HasKey(string keyName)
        {
            this.PK = keyName;
            return this;
        }
        /// <summary>
        /// 设置自增
        /// </summary>
        /// <param name="isauto"></param>
        /// <returns></returns>
        public EntityTypeConfigration IsAutoPKInCrease(bool isauto)
        {
            this.IsAutoPK = isauto;
            return this;
        }
        /// <summary>
        /// 是否忽略字段
        /// </summary>
        /// <param name="isignore"></param>
        /// <returns></returns>
        public EntityTypeConfigration Ignore(string ignoreField)
        {
            IgnoreList.Add(ignoreField);
            return this;
        }
    }
}
