using DependencyInj.Interface;

namespace DependencyInj
{
    public class PersonService : IPersonService
    {
        private readonly Guid _uniqueId;

        public PersonService()
        {
            _uniqueId = Guid.NewGuid();
        }

        public Guid GenerateGuid()
        {
            return _uniqueId;
        }


        public List<string> GetPersonList()
        {
            List<string> personList = new List<string>
            {
                "John",
                "Jane",
                "Alice"
            };
            return personList;
        }
    }
}
