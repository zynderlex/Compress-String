using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(compress("aabbc"));
            Console.ReadKey();
        }
        static string compress(string inp)
        {

            string resultString = "";
            int seq = 1;
            int i;
            
            char[] inpString = inp.ToArray();

            // loop จะวนไปถึงอักษรตัวรองงสุดท้ายเพราะจะเทียบอักษรที่ละคู่ เทียบ Current และ Next ไปเรื่อยๆ
            for (i = 0; i < inpString.Length - 1; i++)
            {
                // ถ้า Current และ Next เหมือนกัน seq จะเพิ่ม
                if (inpString[i] == inpString[i + 1])
                {
                    seq = seq + 1;
                }
                else
                {
                    //เมื่อไม่เหมือน หมายความว่า seq จะหยุดความต่อเนื่องลง อักษร current และ next ต่างกัน จะเก็บอักษร current และ seq 
                    resultString = resultString + seq + inpString[i] + " ";
                    seq = 1;
                }

            }
            /*สำหรับเก็บ seq ของอักษรตัวสุดท้าย (เพราะไม่มีตัวให้เทียบแล้ว) ถ้าเหมือนอักษรก่อนหน้า 
             * แปลว่า seq ถูกเพิ่มมาใน loop แล้ว แต่ถ้าไม่ seq จะเท่ากับ 1 ทันที*/
            resultString = resultString + seq +  inpString[inpString.Length - 1] + " ";
            return resultString;
        }
    }
}

/*
 
     if list empty
        add 1st item to list
     else
        foreach item in list
        if keyinlist == keynewitem
            if keyinlist.value < keynewitem.value
                replace with new keynewitem.value

     */
