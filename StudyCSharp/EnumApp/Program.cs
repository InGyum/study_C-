using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumApp
{
    class Program
    {
        enum DialogResult
        {
            YES,
            NO,
            CANCEL,
            CONFIRM,
            OK
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(DialogResult.OK);
            //Console.WriteLine((int)DialogResult.OK);
            DialogResult result = DialogResult.CONFIRM;
            if(result==DialogResult.CONFIRM)
            {
                Console.WriteLine("CONFIRM 실행");
            }
        }
    }
}
