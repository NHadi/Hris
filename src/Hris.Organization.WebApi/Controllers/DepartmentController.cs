using System;
using System.Threading.Tasks;
using Hris.Application.Services.Interface;
using Hris.Common.API.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Hris.Organization.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMasterService masterService;
        public DepartmentController(IMasterService masterService)
        {
            this.masterService = masterService;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                await masterService.CreateDepartment(new Application.Services.Dto.Master.DepartmentRequest { DepartmentCode = "P01", DepartmentName = "Dummy" });

                var responAPI = await masterService.GetDepartments("P01");
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
