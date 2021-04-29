﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        //Bu bir katmanlı mimari olduğu için business katmanına erişmem gerekiyor ve soyut sınıfdan yapmam gerek.
        //soyut sınıfda bana CarManageri vericek.
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           var result=_carService.GetAll();
            if (result.Success==true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int carid)
        {
           var result= _carService.GetById(carid);
            if (result.Success==true)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
           var result=_carService.Add(car);
            if (result.Success==true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

    }
}