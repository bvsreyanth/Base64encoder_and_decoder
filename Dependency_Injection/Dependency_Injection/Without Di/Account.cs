namespace Dependency_Injection
{
    internal class Account
    {
        CurrentAccount CurrentAccount = new CurrentAccount();
        SavingsAccount SavingsAccount = new SavingsAccount();
        public void PrintAccounts()
        {
            CurrentAccount.PrintDetails();
            SavingsAccount.PrintDetails();
        }
    }
}
