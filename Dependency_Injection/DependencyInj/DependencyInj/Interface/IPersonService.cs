namespace DependencyInj.Interface
{
    public interface IPersonService
    {
        Guid GenerateGuid();
        List<string> GetPersonList();
    }
}
