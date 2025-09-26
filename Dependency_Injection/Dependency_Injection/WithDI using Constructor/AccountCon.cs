namespace Dependency_Injection.WithDI_using_Constructor
{
    internal class AccountCon
    {
        private IAccount _account;
        public AccountCon(IAccount account)
        {
            _account = account;
        }
        public void PrintDetails()
        {
            _account.PrintDetails();
        }
    }
}
