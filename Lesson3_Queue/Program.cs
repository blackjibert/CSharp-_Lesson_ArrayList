using System;
using System.Collections;
namespace Lesson3_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue");
            #region 知识点一 Queue本质
            //Queue是一个C#为我们封装好的类
            //它的本质也是object[]数组，只是封装了特殊的存储规则

            //Queue是队列存储容器
            //Queue是先进先出的数据结构

            #endregion
            #region 知识点二 申明
            //需要引用System.Collections
            Queue queue = new Queue();
            #endregion

            #region 知识点三 增取查改
            //需要引用System.Collections
            #region 增 
            //进队，一个一个进队
            queue.Enqueue(1);
            queue.Enqueue("456"); 
            queue.Enqueue(true);
            queue.Enqueue("hello");
            #endregion
            #region 出队
            //栈中不存在删除的概念
            //只有取的概念，先进先出
            object v = queue.Dequeue();
            Console.WriteLine(v);
            v = queue.Dequeue();
            Console.WriteLine(v);
            #endregion
            #region 查
            //1、查看队列头部元素但不会移除
            
            v = queue.Peek(); //查看不移除
            Console.WriteLine(v);
            v = queue.Peek();
            Console.WriteLine(v);
            //2、查看元素是否存在队列里面
            if (queue.Contains(1.2f))
            {
                Console.WriteLine("存在1.2f");
            }
            else
            {
                Console.WriteLine("不存在1.2f");
            }
            #endregion
            #region 改
            //栈无法改变其中的值 只能进出队列
            //实在要改，只能清空
            Console.WriteLine("改操作:");
            queue.Clear();
            queue.Enqueue("1");
            queue.Enqueue("hello");
            #endregion
            #endregion

            #region 知识点四 遍历
            Console.WriteLine("遍历:");
            //1、长度
            Console.WriteLine("Count:", queue.Count);
            //2、foreach遍历
            //遍历顺序是从栈顶到栈底
            foreach (object item in queue)
            {
                Console.WriteLine(item.ToString());
            }
            //3、还有一种遍历操作
            //将栈转为object数组
            //遍历顺序也是从栈顶到栈底
            object[] array = queue.ToArray();
            Console.WriteLine(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            //4、循环出列
            Console.WriteLine("循环出列Count:", queue.Count);
            while (queue.Count > 0) ;
            {
                object o = queue.Dequeue();
                Console.WriteLine(o);
            }
            Console.WriteLine("Count:", queue.Count);
            #endregion
            #region 知识点五 装箱拆箱
            //由于用万物之父来存储数据，自然存在装箱拆箱
            //当往其中进行值类型存储时就是在装箱
            //当将值类型对象取出来转换使用时，就存在拆箱
            #endregion
        }

    }
}
