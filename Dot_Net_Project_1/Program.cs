using System;

namespace Dot_Net_Project_1
{
    class Program: test
    {
        static void Main(string[] args)
        {
            test p = new test();
            p.pub();
            p.intern();
            Program q = new Program();
            q.protect();
            q.pvt();
            p.prin();
        }

        private void pvt()
        {
            Console.WriteLine("This is Private Method");
        }
    }

    class test
    {
        public void pub()
        {
            Console.WriteLine("This is public Method");
        }
        protected void protect()
        {
            Console.WriteLine("This is protected Method");
        }
        internal void intern()
        {
            Console.WriteLine("This is internal Method");
        }
        protected internal void prin()
        {
            Console.WriteLine("This is protected internal");
        }
    }
}
