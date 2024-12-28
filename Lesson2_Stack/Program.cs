using System;
using System.Collections;
namespace Lesson2_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack");
            #region 知识点一 Stack的本质
            //Stack是一个C#为我们封装好的类
            //它的本质也是object[]数组，只是封装了特殊的存储规则

            //Stack是栈存储容器，栈是一种先进后出的数据结构
            //先存入的数据后获取，后存入的数据先获取
            //栈是先进后出
            #endregion
            #region 知识点二 申明
            //需要引用System.Collections
            Stack stack = new Stack();
            #endregion

            #region 知识点三 增取查改
            //需要引用System.Collections
            #region 增
            //压栈
            stack.Push(1);
            stack.Push("456");
            stack.Push(true);
            stack.Push("hello");
            #endregion
            #region 取
            //栈中不存在删除的概念
            //只有取的概念
            //弹栈
            object v = stack.Pop();
            Console.WriteLine(v);
            v  = stack.Pop();
            Console.WriteLine(v);
            #endregion
            #region 查
            //1、无法查看指定位置的元素
            //只能查看栈顶的内容
            v = stack.Peek(); //查看不弹出
            Console.WriteLine(v);
            v = stack.Peek();
            Console.WriteLine(v);
            //2、查看元素是否存在于栈里面
            if (stack.Contains(1.2f))
            {
                Console.WriteLine("存在1.2f");
            }
            else
            {
                Console.WriteLine("不存在1.2f");
            }
            #endregion
            #region 改
            //栈无法改变其中的值 只能压(存)和弹(取)
            //实在要改，只能清空Clear()
            Console.WriteLine("改操作:");
            stack.Clear();
            stack.Push("1");
            stack.Push("hello");
            #endregion
            #endregion

            #region 知识点四 遍历
            Console.WriteLine("遍历:");
            //1、长度
            Console.WriteLine("Count:",stack.Count);
            //2、foreach遍历
            //遍历顺序是从栈顶到栈底
            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }
            //3、还有一种遍历操作
            //将栈转为object数组
            //遍历顺序也是从栈顶到栈底
            object[] array = stack.ToArray();
            Console.WriteLine(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            //4、循环弹栈
            Console.WriteLine("Count:", stack.Count);
            while (stack.Count > 0);
            {
                object o = stack.Pop();
                Console.WriteLine(o);
            }
            Console.WriteLine("Count:", stack.Count);
            #endregion
            #region 知识点五 装箱拆箱
            //由于用万物之父来存储数据，自然存在装箱拆箱
            //当往其中进行值类型存储时就是在装箱
            //当将值类型对象取出来转换使用时，就存在拆箱
            #endregion
        }
    }

}
