// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Runtime.InteropServices;
namespace Lesson1_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList");
            #region 练习题回顾
            //c#核心中 索引器的练习题
            //自定义一个整型数组类，该类中有一个整形数组变量
            //为它封装 增删改查的方法
            /*            class IntArray
                        {
                            private int[] array;
                            //房间容量
                            private int capacity;
                            //当前放了几个房间；
                            private int length;
                            public IntArray() { }
                            //增
                            public void Add(int value) { }
                            //删
                            public void Remove(int value) { }
                            public void RemoveAt(int index) { }
                            //查改
                            public int this[int index] { }
                        }*/
            #endregion

            #region 知识点一 ArrayList的本质
            //ArrayList是一个C#为我们封装好的类，
            //它的本质是一个object类型的数组，
            //ArrayList类帮助我们实现了很多方法，
            //比如数组的增删改查
            #endregion
            #region 知识点二 申明
            //鼠标点击放在对应所引用类名处，F1跳转至官方文档 https://learn.microsoft.com/zh-cn/search/?scope=.NET&terms=Arraylist
            ArrayList array = new ArrayList();
            #endregion
            #region 知识点三 增删改查
            #region 增
            array.Add(1);
            array.Add("123");
            array.Add(true);
            array.Add(new object());
            ArrayList array2 = new ArrayList();
            array2.Add(123);
            //范围增加（批量增加 把另外一个list容器里面的内容批量添加到后面）
            array.AddRange(array2);
            //在指定位置插入
            array.Insert(1, "1234");
            #endregion
            #region 删
            //移除指定元素，从头找，找到即删
            array.Remove(1);
            //移除指定位置的元素
            array.RemoveAt(2);
            //清空
            //array.Clear();
            #endregion
            #region 查
            //得到指定位置的元素
            Console.WriteLine(array[0]);
            //查看元素是否存在
            if(array.Contains("123"))
            {
                Console.WriteLine("存在123");
              }
            //正向查找元素位置
            //找到的返回值是位置 找不到则返回-1
            int index = array.IndexOf(true);
            Console.WriteLine(index);
            Console.WriteLine(array.IndexOf(false));

            //反向查找元素位置
            index = array.LastIndexOf(true);
            Console.WriteLine(index);
            #endregion
            #region 改
            Console.WriteLine(array[0]);
            array[0] = "999";
            Console.WriteLine(array[0]);
            #endregion
            #endregion
            #region 遍历
            //长度
            Console.WriteLine(array.Count);
            //容量 超过容量会成倍扩容 避免产生过多的垃圾
            Console.WriteLine(array.Capacity);
            //遍历
            for(int i =0;i<array.Count;i++)
            {
                Console.WriteLine(array[i]);            
             }
            //迭代器遍历
            foreach (object item in array)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region 知识点四  装箱拆箱
            //装箱是将值类型（例如 int）转换为引用类型（object），将数据从栈移动到堆。
            //拆箱是将装箱后的数据从引用类型转换回值类型，将数据从堆移动到栈。

            //ArrayList本质是一个可以自动扩容的object数组，
            //由于万物之父来存储数据，自然存在装箱拆箱。
            //当往其中进行值类型存储时就是在装箱，当将值类型对象取出来使用时，就是在拆箱。
            //所以ArrayList尽量少用，之后我们会学习更好的数据容器。
            int k = 1;
            array[0] = k; //装箱，栈上面的数据转移到堆上面
            k = (int)array[0]; //拆箱  ,堆上面的数据转移到栈上面
            #endregion
        }
    }
}
