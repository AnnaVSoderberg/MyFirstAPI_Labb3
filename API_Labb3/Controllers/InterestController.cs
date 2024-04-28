using API_Labb3.Models;
using API_Labb3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Labb3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        private ILabb3Repository<Interest> _interestRepository;
        private ILabb3Repository<Person> _personRepository;
        public InterestController(ILabb3Repository<Interest> interestRepository, ILabb3Repository<Person> personRepository)
        {
            _interestRepository = interestRepository;
            _personRepository = personRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_interestRepository.GetAll());
        }


        //Koppla en person till ett nytt intresse
        [HttpPut ("AddNewInterestToPerson")]
        public IActionResult UpdatePerson(int interestId, int personId) 
        {
            try
            {
                var interestToUpdate = _interestRepository.GetById(interestId);
                var personToUpdate = _personRepository.GetById(personId);
                if(interestToUpdate != null)
                {
                    interestToUpdate.Persons = new List<Person>() { personToUpdate };
                    _interestRepository.Update(interestToUpdate);
                    return Ok(interestToUpdate);
                }
                return NotFound($"Person With id {personId} or interest with id {interestId} was not fund");
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while updating the person with ID {personId} for interest with ID {interestId} in database");
            }
        }


    }
}
