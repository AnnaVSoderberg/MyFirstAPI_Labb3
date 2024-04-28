using API_Labb3.Models;
using API_Labb3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Labb3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ILabb3Repository<Person> _personRepository;
        private readonly ILabb3Repository<Link> _linkRepository;
        private readonly ILabb3Repository<Interest> _interestRepository;

        public PersonController(ILabb3Repository<Person> personrepository, ILabb3Repository<Link> linkRepository, ILabb3Repository<Interest> interestRepository)
        {
            _personRepository = personrepository;
            _linkRepository = linkRepository;
            _interestRepository = interestRepository;
        }

        //Hämta alla personer i systemet
        [HttpGet]
        public IActionResult GettAllPersons()
        {
            return Ok(_personRepository.GetAll());
        }


        [HttpGet("{id:int}")]
        public IActionResult GetSingelPerson(int id)
        {
            var result = _personRepository.GetById(id);
            if(result != null)
            {
                return Ok(result);
            }
            return NotFound($"Person with id {id} not found");
        }

        [HttpGet("GetPersonLinks")]
        public IActionResult GetPersonLinks(int id)
        {
            var links = _linkRepository.GetAll();
            var result = new List<Link>();
            foreach (var link in links)
            {
                if (link.PersonId == id)
                {
                    result.Add(link);
                }
            }

            if (result.Count > 0)
            {
                return Ok(result);
            }
            return NotFound($"No links found for person with id {id}");
        }



        // Hämta alla intressen som är kopplade till en specifik person 
        [HttpGet("GetAPersonsInterests")]
        public IActionResult GetPersonsInterest(int id)
        {
            var interests = _interestRepository.GetAll();
            var result = new List<Interest>();
            foreach (var inte in interests)
            {
                foreach (var person in inte.Persons)
                {
                    if (person.PersonId == id)
                    {
                        result.Add(inte);
                    }
                }
            }
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound($"Person with id {id} no found");
        }


        [HttpPost]
        public IActionResult CreateNewPerson (Person person)
        {
            try
            {
                if(person == null)
                {
                    return BadRequest();
                }
                var newPerson = _personRepository.Add(person);
                return CreatedAtAction(nameof(GetSingelPerson), new { id = newPerson.PersonId }, newPerson);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to post data to database...");
            }
        }

    }
}
