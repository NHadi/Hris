using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hris.Common.API.DTO;
using Hris.Infrastructure.Database.Repositories.Interface;
using Hris.Organization.WebApi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Hris.Organization.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public DepartmentController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {

                await employeeService.CreateDepartment(new Models.DepartmentRequest { DepartmentCode = "P01", DepartmentName = "Test" });

                var responAPI = await employeeService.GetDepartments("P01");
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
