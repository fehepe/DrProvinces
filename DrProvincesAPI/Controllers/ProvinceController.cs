using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DrProvincesAPI.Models;
using DrProvincesAPI.Models.DTOs;
using DrProvincesAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DrProvincesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvinceController : Controller
    {
        private IProvinceRepository _pRepo;
        private readonly IMapper _mapper;

        public ProvinceController(IProvinceRepository pRepo, IMapper mapper)
        {
            _pRepo = pRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProvinces()
        {
            var objList = _pRepo.GetProvinces();

            var objDto = _mapper.Map<IEnumerable<ProvinceDto>>(objList);            

            return Ok(objDto);
        }

        [HttpGet("{id}", Name = "GetProvince")]
        public IActionResult GetProvince(int id)
        {
            var obj = _pRepo.GetProvince(id);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<ProvinceDto>(obj);

            return Ok(objDto);
        }

        [HttpPost]
        public IActionResult CreateProvince([FromBody] ProvinceDto provinceDto)
        {
            if (provinceDto == null)
            {
                return BadRequest(ModelState);
            }
            if (_pRepo.ProvinceExists(provinceDto.Name))
            {
                ModelState.AddModelError("", "Province already Exist!");
                return StatusCode(404, ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }

            var provinceObj = _mapper.Map<Province>(provinceDto);

            if (!_pRepo.CreateProvince(provinceObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {provinceObj.Name}");
                return StatusCode(500, ModelState);
            }

            return CreatedAtRoute("GetProvince", new {id = provinceObj.Id }, provinceObj);
        }
    }
}
