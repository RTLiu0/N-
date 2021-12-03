using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N级项目助手
{
    namespace Duty
    {
        public class Duty 
        {//实现根据level排序
            private string name;
            private int level;
            private int count;
            public int Count
            {
                get { return count; }
                set { count = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Level
            {
                get { return level; }
                set { level = value; }
            }

            
        }
        public class Weight//实现根据level排序
        {
            private decimal level;
            private int count;
            public decimal Level
            {
                get { return level; }
                set { level = value; }
            }
            public int Count
            {
                get { return count; }
                set { count = value; }
            }
        }
    }
    namespace List_line
    {
        public class Mem_list
        {
            public List<Data.Member> members = new List<Data.Member>();
        }
    }
    namespace Data
    {
        
        public class Member
        {
            private string name;
            private string num;//学号
            private string todo;//职责，以分号（；）
            private string type;
            private decimal weight;

            public decimal Weight
            {
                get { return weight; }
                set { weight = value; }
            }
            public string Type
            {
                get { return type; }
                set { type = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Num
            {
                get { return num; }
                set { num = value; }
            }
            public string Todo
            {
                get { return todo; }
                set { todo = value; }
            }
        }

        public class Work
        {
            private string group;
            private string name;
            private string num;
            private string cla;
            private string teacher;
            //private string type;
            public string Group
            {
                get { return group; }
                set { group = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Num
            {
                get { return num; }
                set { num = value; }
            }
           
            public string Cla
            {
                get { return cla; }
                set { cla = value; }
            }
            public string Teacher
            {
                get { return teacher; }
                set { teacher = value; }
            }
           
        }
        namespace File
        {
            class File
            {
                private string rode;//文件路径
                private string name;//文件类型
                public string Rode
                {
                    get { return rode; }
                    set { rode = value; }
                }
                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }
            }
        }
    }
}
