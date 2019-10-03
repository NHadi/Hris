﻿using AutoMapper;
using Hris.Common.API.DTO;
using Hris.Domain.Aggregates.Master;
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
        /// <summary>
        /// Get Department 
        /// </summary>
        /// <param name="code">filter by code</param>
        /// <param name="name">filter by name</param>
        /// <param name="description">filter by description</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(string code = null, string name = null, string description = null)
        {
            try
            {
                var responAPI = await _masterService.GetDepartments(new DepartmentRequest { DepartmentCode = code, DepartmentName = name, Description = description });
                return Ok(new ApiOkResponse(responAPI, responAPI.Count));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiBadRequestResponse(400, "Terjadi Kesalahan"));
            }
        }

        /// <summary>
        /// Get Single Data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var responAPI = await _masterService.GetDepartment(id);
                return Ok(new ApiOkResponse(responAPI));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiBadRequestResponse(400, "Terjadi Kesalahan"));
            }
        }

        /// <summary>
        /// Save Department
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DepartmentRequest request)
        {
            try
            {
                await _masterService.CreateDepartment(request);
                return Ok(new ApiResponse(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiBadRequestResponse(400, "Terjadi Kesalahan"));
            }
        }

        /// <summary>
        /// Update Department
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] DepartmentRequest request)
        {
            try
            {
                await _masterService.UpdateDepartment(id, request);
                return Ok(new ApiResponse(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiBadRequestResponse(400, "Terjadi Kesalahan"));
            }
        }

        /// <summary>
        /// Delete Department
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _masterService.DeleteDepartment(id);
                return Ok(new ApiResponse(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiBadRequestResponse(400, "Terjadi Kesalahan"));
            }
        }
    }
}
