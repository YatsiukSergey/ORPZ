using System;



namespace LAB3
{
    class Program
    {
        public static void Main()
        {
            Client2 client = null;
            client = new Client2(new TeaFactory());
            client.Run();
            client = new Client2(new LateFactory());
            client.Run();
        }
    }
}

