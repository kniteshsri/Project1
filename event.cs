using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesandEvents3
{
    public delegate void Mydel();
    class UseEvent
    {
        public event Mydel MyEvent;//declaration of event.

        public void Hello()
        {
            Console.WriteLine("Hello");
        }
        public void Bye()
        {
            Console.WriteLine("Bye");
        }
        public void CallEvent()
        {
            if (MyEvent != null)//notifying the event.
            {
                Hello();
            }
            else
            {
                Bye();
            }
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            UseEvent Ue = new UseEvent();
	    Mydel md1=new Mydel(Ue.Hello);
            MyEvent me= new MyEvent(Mydel);//Subscribing the event.
            Ue.CallEvent();
            Console.ReadLine();
        }

    }
}
