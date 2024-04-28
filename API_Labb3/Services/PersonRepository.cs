using API_Labb3.Data;
using API_Labb3.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Labb3.Services
{
    public class PersonRepository : ILabb3Repository<Person>
    {
        private AppDbContext _appDbContext;

        public PersonRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Person Add(Person entity)
        {
            if (entity != null)
            {
                _appDbContext.Persons.Add(entity);
                _appDbContext.SaveChanges();
                return entity;
            }
            return null;
        }

        public Person Delete(Person entity)
        {
            var result = GetById(entity.PersonId);
            if(result != null)
            {
                _appDbContext.Persons.Remove(result);
                _appDbContext.SaveChanges();
                return result;
            }
            return null;
        }

        public IEnumerable<Person> GetAll()
        {
            return _appDbContext.Persons;
        }

        public Person GetById(int id)
        {
            return _appDbContext.Persons.FirstOrDefault(x => x.PersonId == id);
        }

        public Person Update(Person entity)
        {
            var person = _appDbContext.Persons.FirstOrDefault(p => p.PersonId == entity.PersonId);
            if(person != null)
            {
                person.Name = entity.Name;
                person.PhoneNumber = entity.PhoneNumber;
                person.Interests = entity.Interests;
                person.Links = entity.Links;
                _appDbContext.SaveChanges();
                return person;
            }
            return null;
        }
    }
}
