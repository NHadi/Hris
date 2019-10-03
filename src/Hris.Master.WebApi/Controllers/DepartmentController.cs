using AutoMapper;
using Hris.Common.API.DTO;
using Hris.Domain.Aggregates.Master.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hris.Master.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMasterService _masterService;
        public DepartmentController(IMasterService masterService)
        {
            _masterService = masterService;
        }
        // GET api/values
        /// <summary>
        /// GEt ALL
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var responAPI = await _masterService.GetDepartments("P01");
                return Ok(new ApiOkResponse(responAPI, responAPI.Count));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiBadRequestResponse(400, "Terjadi Kesalahan"));
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
