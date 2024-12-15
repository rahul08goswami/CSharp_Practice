using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    internal class MSMQ
    {
        public void SendMessage()
        {
            Console.WriteLine("Enter Message, High Priority message should start with HP:");
            string message = Console.ReadLine();
            MessageQueue messageQueue;
            if (MessageQueue.Exists(@".\Private$\MyQueue"))
            {
                messageQueue = new MessageQueue(@".\Private$\MyQueue");
            }
            else
            {
                messageQueue = MessageQueue.Create(@".\Private$\MyQueue");
            }
            Message message1 = new Message();
            message1.Formatter = new BinaryMessageFormatter();
            message1.Body = message;
            message1.Label = "From Sender";
            if (message.Contains("HP:"))
                message1.Priority = MessagePriority.High;
            else message1.Priority = MessagePriority.Normal;

            messageQueue.Send(message1);
            Console.WriteLine("Thanks for Sending!");

        }

        public void ReadMessage()
        {
            Console.WriteLine("Latest Message");
            MessageQueue messageQueue = new MessageQueue(@".\Private$\MyQueue");
            Message message1 = messageQueue.Receive();
            message1.Formatter = new BinaryMessageFormatter();
            string ReadMsg = message1.Body.ToString();
            if (String.IsNullOrEmpty(ReadMsg))
                Console.WriteLine("No message to display");
            Console.WriteLine(ReadMsg);

        }
    }
}
