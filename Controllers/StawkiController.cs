using Jppapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jppapi.Data;
using Jppapi.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

namespace Jppapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StawkiController : ControllerBase
    {

        private readonly IStawkieRepo _repository;
        private readonly IMapper _mapper;

        public StawkiController(IStawkieRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        //Get api/stawki
        [HttpGet]
        public ActionResult<IEnumerable<StawkaReadDto>> Get()
        {
            var stawkiItems = _repository.GetAllStawki();
            return Ok(_mapper.Map<IEnumerable<StawkaReadDto>>(stawkiItems));
        }



        //GET api/stawki/{id}
        [HttpGet("{id}", Name = "GetStawkaById")]
        public ActionResult<StawkaReadDto> GetStawkaById(int id)
        {
            var stawkaItem = _repository.GetStawkaById(id);
            if (stawkaItem != null)
            {
                return Ok(_mapper.Map<StawkaReadDto>(stawkaItem));
            }
            return NotFound();
        }

        //Post api/stawki
        [HttpPost]
        public ActionResult<StawkaCreateDto> CreateStawkaDto(StawkaCreateDto stawkaCreateDto)
        {
            var stawkaModel = _mapper.Map<Stawka>(stawkaCreateDto);
            _repository.CreateStawka(stawkaModel);

            _repository.SaveChanges();
            return Ok(_mapper.Map<StawkaReadDto>(stawkaModel));
        }

        //[HttpPost]
        //public ActionResult<StawkaCreateDto> CreateStawka(Stawka stawkaModel)
        //{
        //    _repository.CreateStawka(stawkaModel);
        //    _repository.SaveChanges();
        //    var stawkaReadDto = _mapper.Map<StawkaReadDto>(stawkaModel);
        //    //  return Ok(_mapper.Map<StawkaReadDto>(stawkaModel));

        //    return CreatedAtRoute("GetStawkaById", new { Id = stawkaReadDto.Stawki_id }, stawkaReadDto);
        //}


        //PUT api/stawki
        [HttpPut("{id}")]
        public ActionResult UpdateStawka(int id, StawkaUpdateDto stawkaUpdateDto)
        {
            var stawkaModelFromRepo = _repository.GetStawkaById(id);
            if (stawkaModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(stawkaUpdateDto, stawkaModelFromRepo);

            _repository.UpdateStawka(stawkaModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
        //PATCH api/stawki/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialStawkiUpdate(int id, JsonPatchDocument<StawkaUpdateDto> patchDoc)
        {
            var stawkiModelFromRepo = _repository.GetStawkaById(id);
            if (stawkiModelFromRepo == null)
            {
                return NotFound();
            }

            var stawkaToPatch = _mapper.Map<StawkaUpdateDto>(stawkiModelFromRepo);
            patchDoc.ApplyTo(stawkaToPatch, ModelState);
            if (!TryValidateModel(stawkaToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(stawkaToPatch, stawkiModelFromRepo);
            _repository.UpdateStawka(stawkiModelFromRepo);
            _repository.SaveChanges();
            return NoContent();

        }
        //DELETE api/stawki/{id}
        [HttpDelete("{id}")]
        public ActionResult  DeleteStawka(int id)
        {
            var stawkiModelFromRepo = _repository.GetStawkaById(id);
            if (stawkiModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteStawka(stawkiModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
