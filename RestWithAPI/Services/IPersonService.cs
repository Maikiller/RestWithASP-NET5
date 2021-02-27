using RestWithAPI.Model;
using System.Collections.Generic;

namespace RestWithAPI.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person Update(Person person);

        Person FindByID(long id);

        List<Person> FindAll();

        void Delete(long id);
    }
}