using API_Labb3.Data;
using API_Labb3.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Labb3.Services
{
    public class InterestRepository : ILabb3Repository<Interest>
    {
        private AppDbContext _appDbContext;
        public InterestRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Interest Add(Interest entity)
        {
            if(entity != null)
            {
                _appDbContext.Interests.Add(entity);
                _appDbContext.SaveChanges();
                return entity;
            }
            return null;
        }

        public Interest Delete(Interest entity)
        {
            var result = GetById(entity.InterestId);
            if(result != null)
            {
                _appDbContext.Interests.Remove(result);
                _appDbContext.SaveChanges();
                return result;
            }
            return null;
        }

        public IEnumerable<Interest> GetAll()
        {
            return _appDbContext.Interests.Include(i => i.Persons);
        }

        public Interest GetById(int id)
        {
            return _appDbContext.Interests.FirstOrDefault(i => i.InterestId == id);
        }

        public Interest Update(Interest entity)
        {
            var interestToUpdate = _appDbContext.Interests.FirstOrDefault(i => i.InterestId == entity.InterestId);
            if (interestToUpdate != null)
            {
                interestToUpdate.Title = entity.Title;
                interestToUpdate.Description = entity.Description;
                interestToUpdate.Persons = entity.Persons;
                interestToUpdate.Links = entity.Links;
                _appDbContext.SaveChanges();
                return interestToUpdate;
            }
            return null;
        }
    }
}
