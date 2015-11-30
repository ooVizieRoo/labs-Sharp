using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{
    class MessageSender
    {
        private int Send(byte[] buf)
        {
            return buf.Length;
        }

        public void SendMessage(string msg)
        {
            byte[] buf;

            buf = new byte[msg.Length * sizeof(char)];
            Buffer.BlockCopy(msg.ToCharArray(), 0, buf, 0, buf.Length);

            Send(buf);
        }
    }
}
