using Microsoft.AspNetCore.Mvc;
using SampleApp.API.DTOs;
using SampleApp.Domain.Business;
using AutoMapper;

namespace SampleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ICommonManager _commonManager;
        private readonly IMapper _mapper;

        public HomeController(ICommonManager commonManager, IMapper mapper)
        {
            this._commonManager = commonManager;
            this._mapper = mapper;
        }
        
        /// <summary>
        /// Post API to recieve name and address data and update it
        /// </summary>
        /// <param name="personDto"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public IActionResult AddData([FromBody] PersonDto personDto)
        {
            if (string.IsNullOrEmpty(personDto.Name)) // Make Name required
            {
                return BadRequest("Name is required");
            }
            var result = _commonManager.AddData(_mapper.Map<Domain.DTOs.PersonDto>(personDto));
            return Ok(result);
        }
    }
}
