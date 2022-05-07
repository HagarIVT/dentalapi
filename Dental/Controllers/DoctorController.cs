using Dental.Contract;
using Dental.Core.Entities;
using Dental.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : Controller
    {
       
            private readonly IDoctorRepo _DoctorRepository;


            public DoctorController(IDoctorRepo DoctorRepository)
            {
            _DoctorRepository = DoctorRepository;

            }


            
        [HttpGet("GetAllDoctors")]  
        public async Task<IActionResult> GetAllDoctors()
            {
                try
                {
                var result = await _DoctorRepository.GetAllDoctors();


                    if (result == null) return NotFound();

                    return Ok(result);
                }
                catch (Exception)
                {
                    return BadRequest("Bad Request");
                }
            }
     
        
        [HttpGet("GetDoctorByID/{id:int}")]  
        public async Task<IActionResult> GetDoctorByID(int id)
            {
                try
                {
                var result = await _DoctorRepository.GetDoctorByID(id);


                    if (result == null) return NotFound();

                    return Ok(result);
                }
                catch (Exception)
                {
                    return BadRequest("Bad Request");
                }
            }

        
        [HttpPost("AddDoctor")]
        public async Task<IActionResult> AddDoctor(DoctorDTO request)
        {
            try
            {
                var d = await _DoctorRepository.AddDoctor(request);
                return Ok();
            }
            catch (Exception ex)
            {

                return Ok(ex);
            }

        }

    }
}
