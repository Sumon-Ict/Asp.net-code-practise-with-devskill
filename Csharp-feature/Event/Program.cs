using System;

namespace Event
{
    class Program
    {
     

        public delegate void notify(string address, string message);
        public event notify notifiaction;

        static void Main(string[] args)
        {

            var P = new Program();
            P.notifiaction += emailnotification;
            P.notifiaction += messagenotification;
            P.notifiaction += warningmessage;


            P.notifiaction("sumon", "hellow world");
            P.notifiaction -= messagenotification;
            P.notifiaction -= emailnotification;


            P.notifiaction("sujon", "hellow ");
            



            /*
            mydelegate logic = new mydelegate(newprintmethod);

            var text = "my name is sumon";
            //dl("may name is sumon");

            logic(text);   

            printprocess(text, logic);

            */



        }

        static void emailnotification(string address, string message)
        {
            Console.WriteLine("sending message to {0} with message {1}", address, message);

        }
       static void messagenotification(string address,string m)
        {
            Console.WriteLine("sending message {0} with message  {1}", address, m);

        }
        static void warningmessage(string add,string m)
        {
            Console.WriteLine($"sending mail {add} with warning message {m}");


        }


        /*
        static void printmethod(string s)
        {
            Console.WriteLine("--- {0} ------", s);

        }
        static void newprintmethod(string s)
        {
            Console.WriteLine("new way of printing {0}", s);

        }

        static void printprocess(string text,mydelegate dl)
        {
            if(!string.IsNullOrWhiteSpace(text))
            {
                dl(text);

            }
        }
        */


    }
}
