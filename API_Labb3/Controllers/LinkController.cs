using API_Labb3.Models;
using API_Labb3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Labb3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private ILabb3Repository<Link> _linkRepository;

        public LinkController(ILabb3Repository<Link> linkRepository)
        {
            _linkRepository = linkRepository;
        }

        [HttpGet]
        public IActionResult GetAllLinks()
        {
            return Ok(_linkRepository.GetAll());
        }

        [HttpPost("LinkToPersonAndInterest")]

        //Lägga in nya länkar för en specifik person och ett specifikt intresse
        public IActionResult CreateNewLink(string url, int personId, int interestId)
        {
            try
            {
                Link linkToAdd = new Link() { Url = url, PersonId = personId, InterestId = interestId};
                _linkRepository.Add(linkToAdd);
                return Ok(linkToAdd);


            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to create new link in database");
            }

        }

    }
}
