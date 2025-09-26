using Dependency_Injection.WithDI_using_property;

public class Program
{
    public static void Main(string[] args)
    {
        ////without DI (Tight Coupling)
        //    Account ac = new Account();
        //    ac.PrintAccounts();
        //    Console.ReadLine();

        ////With DI using Constructor
        //IAccount ca = new CurrentWithConstructor();
        //AccountCon a = new AccountCon(ca);
        //a.PrintDetails();
        //IAccount sa = new SavingsWithConstructor();
        //AccountCon account = new AccountCon(sa);
        //account.PrintDetails();
        // Console.ReadLine();

        ////WithProperty
        Client cA = new Client();
        cA.Service = new Resource1();
        cA.Serve();

        ////WithMethods
        //AccountMethod sa = new AccountMethod();
        //sa.prinAccount(new SavingsWithMethod());
        //AccountMethod cu = new AccountMethod();
        //cu.prinAccount(new CurrentWithMethod());
        //Console.ReadLine();
    }
}