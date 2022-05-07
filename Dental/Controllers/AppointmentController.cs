using Dental.Contract.DTO;
using Dental.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentRepo _AppointmentRepo;


        public AppointmentController(IAppointmentRepo AppointmentRepo)
        {
            _AppointmentRepo = AppointmentRepo;

        }

        [HttpPost("CreateAppointment")]
        public async Task<IActionResult> CreateAppointment(ClientAppointmentDTO request)
        {
            try
            {
                var d = await _AppointmentRepo.CreateAppointment(request);
                return Ok();
            }
            catch (Exception ex)
            {

                return Ok(ex);
            }

        }


        [HttpGet("GetAllAppointment")]

        public async Task<IActionResult> GetAllAppointment()
        {
            try
            {
                var result = await _AppointmentRepo.GetAllAppointment();


                if (result == null) return NotFound();

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest("Bad Request");
            }
        }
    }
}
