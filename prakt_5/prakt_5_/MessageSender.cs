using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5_
{
    class MessageSender
    {
        BufferFactory bf = new BufferFactory();

        private int Send(byte[] buf)
        {
            return buf.Length;
        }

        public void SendMessage(string msg)
        {

            AbstractBuffer ab = bf.Get(msg.Length * sizeof(char));
            Buffer.BlockCopy(msg.ToCharArray(), 0, ab.b, 0, ab.b.Length);

            Console.WriteLine(Send(ab.b));
        }
    }
}
