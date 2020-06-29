using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOPProjectCsharp
{
    [Serializable]
    class Message
    {
       private string from;
       private string to;
       private string message;
       private string subject;
       public string  From
        {
            set
            {
                from = value;
            }
            get
            {
                return from;
            }
        }
        public string To
        {
            set
            {
                to = value;
            }
            get
            {
                return to;
            }
        }
        public string Subject
        {
            set
            {
                subject = value;
            }
            get
            {
                return subject;
            }
        }
        public string _Message
        {
            set
            {
                message = value;
            }
            get
            {
                return message;
            }
        }
        public void SendMessage(string From,string to,string message,string subject="No Subject")
        {
            Message obj = new Message();
            obj.From = From;
            obj.To = to;
            obj._Message = message;
            obj.Subject = subject;
            string path = "Messages.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();
            
        }
    }
}
