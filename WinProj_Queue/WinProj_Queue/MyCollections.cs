using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections; //add this queue stack tec...

namespace WinProj_Queue
{
    class MyCollections
    {
    }

    class QueueBuffer 
    {
        private Queue mBuffer;

        public void SendMessage(Message m) 
        {
            mBuffer.Enqueue(m);
        }
        public void ReceiveMessage() 
        {
            Message m = (Message)mBuffer.Dequeue(); //透過Dequeue讀取出來
            Console.WriteLine(m.ToString());
        }

        public QueueBuffer() 
        {
            mBuffer = new Queue();
        }

    }
    public class Message 
    {
        private string messageText;
        public Message(string str) 
        {
            messageText = str;
        }
        public override string ToString()
        {
            return messageText;
        }
    }

    public class StackBuffers 
    {
        private Stack sBuffer;

        public void SendMessage(Message m) 
        {
            sBuffer.Push(m); //透過push儲存m
        }
        public void ReceiveMessage()
        {
            Message m = (Message)sBuffer.Pop(); //透過pop讀取出來
            Console.WriteLine(m.ToString());
        }

        public StackBuffers() 
        {
            sBuffer = new Stack();
        }
    }

    public class Car 
    {
        int _no;
        string _model;

        //建構子
        public Car(int _no, string _model) 
        {
            this._no = _no;
            this._model = _model;
        }

        public override string ToString()
        {
            return "NO: " + _no + "\tModel: " + _model;
        }
        public string Name 
        {
            set { _model = value; }
        }
    }
}
