using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jiecheng
{
    class jiecheng
    {
        public int Jc(int num)
        {
            return num > 0 ? num * Jc(num - 1) : 1;
            //如果num>0则返回num*(num-1),否则返回1
        }
    }
    class excutejiecheng
    {
        static void Main(string[] args)
        {
            jiecheng n = new jiecheng();
            int result = n.Jc(Convert.ToInt16(Console.ReadLine()));
            //控制台输入一个值，通过Convert.ToInt16()转成int类型 
            //int16：-32768 到 32767
            //int32：-2,147,483,648 到 2,147,483,647
            Console.Write("result is {0}", result);
            Console.ReadKey();
        }
    }
}
