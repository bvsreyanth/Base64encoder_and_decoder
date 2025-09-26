namespace Dependency_Injection.With_DI_using_Method
{
    internal class SavingsWithMethod : IAccountMethod
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Savings Account ");
        }
    }
}
