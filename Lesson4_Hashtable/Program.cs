using System;
using System.Collections;
namespace Lesson4_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable");
            #region 知识点一 Hashtable的本质
            //Hashtable（又称为散列表）是基于键的哈希代码组织起来的 键值对
            //它的主要作用是提高数据的查询效率
            //使用键来访问集合中的元素
            #endregion
            #region 知识点二 申明
            //需要引用System.Collections
            Queue queue = new Queue();
            #endregion
            //需要引用命名空间 System.Collections
            Hashtable hashtable = new Hashtable();
            #region 知识点三 增删查改

            #region 增 
            hashtable.Add(1, "123");
            hashtable.Add("123", 2);
            hashtable.Add(true, true);
            hashtable.Add(false, false);
            //不能出现相同的键
            //hashtable.Add(1, "123");
            #endregion
            #region 删
            //1.只能通过键去删除
            hashtable.Remove(1);

            //2.删除不存在的键，没反应
            hashtable.Remove(3);
            //3.或者直接清空
            // hashtable.Clear();
            #endregion
            #region 查
            //1、通过键来查看值
            //找不到返回空
            Console.WriteLine(hashtable[1]);
            Console.WriteLine(hashtable["345"]); //null
            //2、查看是否存在
            //根据键检测
            if (hashtable.Contains("2"))
            {
                Console.WriteLine("存在键为[2]的键值对");
            }
            if (hashtable.ContainsKey(1))
            {
                Console.WriteLine("存在键为1的键值对");
            }
            //根据值检测
            if (hashtable.ContainsValue("123"))
            {
                Console.WriteLine("存在值为[123]的键值对");
            }
            #endregion
            #region 改
            //只能改键对应的值内容 无法修改键 
            Console.WriteLine(hashtable[1]);
            hashtable[1] = "hello";
            Console.WriteLine(hashtable[1]);
            #endregion
            #endregion

            #region 知识点四 遍历
            //1.遍历所有键
            //得到键值对对数
            Console.WriteLine(hashtable.Count);

            foreach (string key in hashtable.Keys)
            {
                Console.WriteLine("键:"+key);
                Console.WriteLine("对应值:"+hashtable[key]);
            }
            //2.遍历所有值
            foreach (string value in hashtable.Values)
            {
                Console.WriteLine("值:" + value);
            }

            //3.键值对一起遍历
            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine("键:"+item.Key + "值:" + item.Value);
            }
            //4.迭代器遍历法
            IDictionaryEnumerator   myEnunerator =hashtable.GetEnumerator();
            bool flag = myEnunerator.MoveNext();
            while (flag) 
            {
                Console.WriteLine("键:" + myEnunerator.Key + "值:" + myEnunerator.Value)
                flag = myEnunerator.MoveNext();
            }
            #endregion
            #region 知识点五 装箱拆箱
            //由于用万物之父来存储数据，自然存在装箱拆箱
            //当往其中进行值类型存储时就是在装箱
            //当将值类型对象取出来转换使用时，就存在拆箱
            #endregion
        }

    }
}
