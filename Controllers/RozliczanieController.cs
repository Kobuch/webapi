using Microsoft.AspNetCore.Mvc;
using Jppapi.Data;
using Jppapi.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using Jppapi.Models;

namespace Jppapi.Controllers
{
    [Route("{login}/api/[controller]")]
    [ApiController]
    public class RozliczanieController : ControllerBase
    {
        private readonly IRozliczanieDniiRepo _repository;
        private readonly IMapper _mapper;
        private readonly ILogowanieRepo _reposPomocnicze;

        public RozliczanieController(IRozliczanieDniiRepo repository, IMapper mapper, ILogowanieRepo logowanieRepo)
        {
            _repository = repository;
            _mapper = mapper;
            _reposPomocnicze = logowanieRepo;
        }


        //Get {login}/api/rozliczanie
        [HttpGet]
        public ActionResult<IEnumerable<RozliczeniaDniaReadDto>> Get(string login)
        {
            if (!_reposPomocnicze.CzyMaUprawnienia(login)) return Content("Brak uprawnien do dostepu do danych");

            // var rozliczanieDniaItems = _repository.GetAllRozliczenieDnia();
            var rozliczanieDniaItems = _repository.GetOwnRozliczenieDnia(login);
            return Ok(_mapper.Map<IEnumerable<RozliczeniaDniaReadDto>>(rozliczanieDniaItems));
        }

        //Get {login}/api/rozliczanie/{id}
        [HttpGet("{id}", Name = "GetRozliczenieDniaById")]
        public ActionResult<RozliczeniaDniaReadDto> GetRozliczeniaDniabyid(int id, string login)
        {
            if (!_reposPomocnicze.CzyMaUprawnienia(login)) return Content("Brak uprawnien do dostepu do danych");

            var rozliczanieDniaItems = _repository.GetRozliczenieDniaById(id);
            if (rozliczanieDniaItems != null)
            {
                return Ok(_mapper.Map<RozliczeniaDniaReadDto>(rozliczanieDniaItems));
            }
            return NotFound();
        }

        //Post {login}/api/rozliczanie
        [HttpPost]
        public ActionResult<RozliczeniaDniaReadDto> CreateRozliczeniaDniaDto(RozliczeniaDniaCreateDto  rozliczeniaDniaCreateDto, string login)
        {
            if (!_reposPomocnicze.CzyMaUprawnienia(login)) return Content("Brak uprawnien do dostepu do danych");

            var rozliczanieDniaModel = _mapper.Map<RozliczenieDnia>(rozliczeniaDniaCreateDto);
            _repository.CreateRozliczenieDnia(rozliczanieDniaModel);

            _repository.SaveChanges();
            return Ok(_mapper.Map<RozliczeniaDniaReadDto>(rozliczanieDniaModel));
        }

        //PUT {login}/api/rozliczanie
        [HttpPut("{id}")]
        public ActionResult UpdateRozliczeniaDnia(int id, RozliczeniaDniaUpdateDto  rozliczeniaDniaUpdateDto, string login)
        {
            if (!_reposPomocnicze.CzyMaUprawnienia(login)) return Content("Brak uprawnien do dostepu do danych");

            var rozliczeniaDniaModelFromRepo = _repository.GetRozliczenieDniaById(id);
            if (rozliczeniaDniaModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(rozliczeniaDniaUpdateDto, rozliczeniaDniaModelFromRepo);

            _repository.UpdateRozliczenieDnia(rozliczeniaDniaModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH {login}/api/rozliczanie/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialRozliczeniaDniaUpdate(int id, JsonPatchDocument<RozliczeniaDniaUpdateDto> patchDoc)
        {
            var rozliczeniaDniaModelFromRepo = _repository.GetRozliczenieDniaById(id);
            if (rozliczeniaDniaModelFromRepo == null)
            {
                return NotFound();
            }

            var rozliczeniaDniaToPatch = _mapper.Map<RozliczeniaDniaUpdateDto>(rozliczeniaDniaModelFromRepo);
            patchDoc.ApplyTo(rozliczeniaDniaToPatch, ModelState);
            if (!TryValidateModel(rozliczeniaDniaToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(rozliczeniaDniaToPatch, rozliczeniaDniaModelFromRepo);
            _repository.UpdateRozliczenieDnia(rozliczeniaDniaModelFromRepo);
            _repository.SaveChanges();
            return NoContent();

        }

        //DELETE {login}/api/rozliczanie/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteRozliczeniaDnia(int id)
        {
            var rozliczeniaDniaModelFromRepo = _repository.GetRozliczenieDniaById(id);
            if (rozliczeniaDniaModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteRozliczenieDnia(rozliczeniaDniaModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
