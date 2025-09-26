namespace Dependency_Injection.With_DI_using_Method
{
    public class CurrentWithMethod : IAccountMethod
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Current Account ");
        }
    }
}
