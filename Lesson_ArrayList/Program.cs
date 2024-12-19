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
        }
    }

}
