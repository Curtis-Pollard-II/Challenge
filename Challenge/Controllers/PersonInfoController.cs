using System;
using System.Collections.Generic;
using Challenge.Models;
using Challenge.Services;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonInfoController : ControllerBase
    {
        private readonly PersonInfoServices _PIService;

        public PersonInfoController(PersonInfoServices pIService)
        {
            _PIService = pIService;
        }



        [HttpGet]

        public ActionResult<List<PersonInfo>> GetAll()
        {
            try 
            {
              List<PersonInfo> persons = _PIService.GetAll();
              return Ok(persons);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }
    }
}