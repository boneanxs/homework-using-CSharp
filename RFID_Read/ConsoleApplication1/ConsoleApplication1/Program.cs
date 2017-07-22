using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcnt = 0;
            string binarystr = "1101";
            byte[] filterbytes = new byte[(binarystr.Length - 1) / 8 + 1];

            for (int c = 0; c < filterbytes.Length; ++c)
                filterbytes[c] = 0;

            foreach (Char ch in binarystr)
            {
                if (ch == '1')
                    filterbytes[bitcnt / 8] |= (byte)(0x01 << (7 - bitcnt % 8));
                bitcnt++;
                
            }
            foreach (byte ch in filterbytes)
            {
                Console.Write(ch);
            }
            Console.Write("yeah");
        }
    }
}
