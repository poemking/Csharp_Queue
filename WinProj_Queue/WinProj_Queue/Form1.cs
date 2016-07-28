using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections; //add this to use arraylist

namespace WinProj_Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Queue是先進先出
        private void button1_Click(object sender, EventArgs e)
        {
            QueueBuffer b = new QueueBuffer();
            b.SendMessage(new Message("1st"));
            b.SendMessage(new Message("2nd"));
            b.ReceiveMessage(); //到這行會讀1st obj
            b.SendMessage(new Message("3rd"));
            b.ReceiveMessage(); //到這行會讀2nd obj
            b.SendMessage(new Message("4th"));
            b.ReceiveMessage(); //到這行會讀3rd obj
            b.ReceiveMessage(); //到這行會讀4th obj
        }

        //stack是後進先出
        private void button2_Click(object sender, EventArgs e)
        {
            StackBuffers b = new StackBuffers();
            b.SendMessage(new Message("1st"));
            b.SendMessage(new Message("2nd"));
            b.SendMessage(new Message("3rd"));
            b.SendMessage(new Message("4th"));
            b.ReceiveMessage(); //到這行會讀4th obj
            b.ReceiveMessage(); //到這行會讀3rd obj
            b.ReceiveMessage(); //到這行會讀2nd obj
            b.ReceiveMessage(); //到這行會讀1st obj
        }
        //arraylist
        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            Car c = new Car(1, "Porche");
            list.Add(c);
            c = new Car(2, "Ford");
            list.Add(c);
            c = new Car(3, "Toyota");
            list.Add(c);
            c = new Car(4, "No Brand");
            list.Insert(1, c); //插入到1的index下方
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
            Console.WriteLine("=====================");
            list.RemoveAt(1); //No Brand會被刪除掉
            Car c1 = (Car)list[2];
            c1.Name = "YunLoong"; //把index2也就是Toyota改成YunLoong
            foreach (object obj in list)
                Console.WriteLine(obj);
            /*Result
                NO: 1	Model: Porche
                NO: 4	Model: No Brand
                NO: 2	Model: Ford
                NO: 3	Model: Toyota
                =====================
                NO: 1	Model: Porche
                NO: 2	Model: Ford
                NO: 3	Model: YunLoong
             */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            Car c = new Car(1, "Porche");
            ht.Add("PORCHE",c);  
            c = new Car(2, "Ford");
            ht.Add("FORD", c);
            c = new Car(3, "Toyota");
            ht.Add("TOYOTA", c); ;
            c = new Car(4, "No Brand");
            ht.Add("NA", c); ;
            foreach (DictionaryEntry entry in ht) 
            {
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            }
            //key is index ,value is 內容
            foreach (string k in ht.Keys) 
            {
                Console.WriteLine("{0},", ht[k]);
            }
            ht.Remove("NA");
            Car v = (Car)ht["FORD"];
            v.Name = "YueLoong";
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            }
            /*Result 有點怪 第一個應該要顯示Key:PORCHE	Value:NO: 1	Model: Porche <==有空再看
                Key:FORD	Value:NO: 2	Model: Ford
                Key:PORCHE	Value:NO: 1	Model: Porche
                Key:TOYOTA	Value:NO: 3	Model: Toyota
                Key:NA	Value:NO: 4	Model: No Brand
                NO: 2	Model: Ford,
                NO: 1	Model: Porche,
                NO: 3	Model: Toyota,
                NO: 4	Model: No Brand,
                Key:FORD	Value:NO: 2	Model: YueLoong
                Key:PORCHE	Value:NO: 1	Model: Porche
                Key:TOYOTA	Value:NO: 3	Model: Toyota
             */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //SortedList英文字母越小的排在越上面 反之則然!!
            SortedList ht = new SortedList();
            Car c = new Car(1, "Porche");
            ht.Add("PORCHE", c);
            c = new Car(2, "Ford");
            ht.Add("FORD", c);
            c = new Car(3, "Toyota");
            ht.Add("TOYOTA", c); ;
            c = new Car(4, "No Brand");
            ht.Add("NA", c); ;
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            }
            //透過key like index 可得value like data
            foreach (string k in ht.Keys)
            {
                Console.WriteLine("{0},", ht[k]);
            }
            ht.Remove("NA");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            }

            /*Result
                Key:FORD	Value:NO: 2	Model: Ford
                Key:NA	Value:NO: 4	Model: No Brand
                Key:PORCHE	Value:NO: 1	Model: Porche
                Key:TOYOTA	Value:NO: 3	Model: Toyota
                NO: 2	Model: Ford,
                NO: 4	Model: No Brand,
                NO: 1	Model: Porche,
                NO: 3	Model: Toyota,
                Key:FORD	Value:NO: 2	Model: Ford
                Key:PORCHE	Value:NO: 1	Model: Porche
                Key:TOYOTA	Value:NO: 3	Model: Toyota
             */
        }
    }
}
