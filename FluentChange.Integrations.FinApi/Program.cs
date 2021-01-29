using System;

namespace FluentChange.Integrations.FinApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string dummyUserId = "xxxx";
            //long dkbBankId = 24353;
            string dummyPass = "xxxx";

            var t = new Client("[Replace]", "[Replace]");
            //var user = t.CreateUser(userId);

            //var connections = t.AllConnections(userId,pass);
            //foreach(var con in connections.Connections)
            //{
            //    Console.WriteLine("CON " + con.Bank.Name);
            //    Console.WriteLine("   S " + con.UpdateStatus);
            //    foreach (var account in con.AccountIds)
            //    {
            //        Console.WriteLine("  A " + account);
            //    }
            //}
            t.SearchBanks("dkb");

            Console.WriteLine("finished - press key");
            Console.ReadKey();
        }
    }
}
