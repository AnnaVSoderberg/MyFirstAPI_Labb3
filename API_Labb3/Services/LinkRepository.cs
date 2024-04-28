using API_Labb3.Data;
using API_Labb3.Models;

namespace API_Labb3.Services
{
    public class LinkRepository : ILabb3Repository<Link>
    {
        private AppDbContext _appDbContext;

        public LinkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Link Add(Link entity)
        {
            if(entity != null)
            {
                _appDbContext.Links.Add(entity);
                _appDbContext.SaveChanges();
                return entity;
            }
            return null;
        }

        public Link Delete(Link entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Link> GetAll()
        {
            return _appDbContext.Links;
        }

        public Link GetById(int id)
        {
            return _appDbContext.Links.FirstOrDefault(l => l.Id == id);
        }

        public Link Update(Link entity)
        {
            throw new NotImplementedException();
        }
    }
}
