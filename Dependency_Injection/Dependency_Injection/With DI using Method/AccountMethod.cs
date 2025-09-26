namespace Dependency_Injection.With_DI_using_Method
{
    internal class AccountMethod
    {
        public void prinAccount(IAccountMethod accountMethod)
        {
            accountMethod.PrintDetails();
        }
    }
}
