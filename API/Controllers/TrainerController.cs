using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using API.DTOs;
using AutoMapper;
using Infrastructure.UnityOfWork;
using API.Helpers;

namespace API.Controllers
{
    [ApiController]
    [Route("api/controler/trainer")]
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class TrainerController : ControllerBase
    {
        private readonly IUnityOfWork unityOfWork;
        private readonly IMapper mapper;

        public TrainerController(IUnityOfWork unityOfWork, IMapper mapper)
        {
            this.unityOfWork = unityOfWork;
            this.mapper = mapper;
        }
        // [HttpGet]
       
        // [ProducesResponseType(StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status404NotFound)]
        // [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // public async Task<ActionResult<IEnumerable<Trainer>>> GetTrainers()
        // {
        //     var actores = await unityOfWork.Trainers.
        //     GetAllTrainersAsync();
        //     return Ok(actores);
        // }
        [HttpGet]
        public async Task<ActionResult<Pager<Trainer>>> Get([FromQuery] Params trainerParams)
        {
            var trainer = await unityOfWork.Trainers.GetAllTrinerAsync(trainerParams.PageIndex, trainerParams.PageSize, trainerParams.Search);
            var listadoTrainers = trainer.registros;
            return new Pager<Trainer>(listadoTrainers,trainer.totalRegistros,trainerParams.PageIndex,trainerParams.PageSize,trainerParams.Search); 
        }
        [HttpGet("ById/{id}")]
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Trainer>> GetById(int id)
        {
            var actor = await unityOfWork.Trainers.GetTrainerByIdAsync(id);
            if (actor is null)
            {
                return NotFound();
            }
            return Ok(actor);
        }
        [MapToApiVersion("1.1")]
        [HttpGet("getByName/{name}")]
        
        public async Task<IEnumerable<Trainer>> GetTrainerByName(string name)
        {
            return await unityOfWork.Trainers.GetTrainersByName(name);
        }

        [HttpPost]
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostTrainers(IEnumerable<TrainerDTO> trainersDTOs)
        {
            var trainers = mapper.Map<IEnumerable<Trainer>>(trainersDTOs);
            unityOfWork.Trainers.AddRangeT(trainers);
            await unityOfWork.SaveAsync();
            return Ok();
        }
        [HttpPost("emails")]
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostEmail(EmailTrainerCreationDTO[] emailsTrainerDTOs)
        {
            var emailtrainers = mapper.Map<EmailsTrainers[]>(emailsTrainerDTOs);
            unityOfWork.Trainers.AddRangeEmail(emailtrainers);
            await unityOfWork.SaveAsync();
            return Ok();
        }
        [HttpPost("telefonos")]
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostTelefonos(TelefonoTrainerCreationDTO[] telefonostrainerDTOs)
        {
            var telefonos = mapper.Map<TelefonosTrainers[]>(telefonostrainerDTOs);
            unityOfWork.Trainers.AddRangeTelefono(telefonos);
            await unityOfWork.SaveAsync();
            return Ok();
        }
        [HttpPut("{id}")]
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TrainerDTO>> Put(int id, [FromBody] TrainerDTO trainerDTO)
        {
            var trainer = mapper.Map<Trainer>(trainerDTO);
            if (trainer == null)
            {
                return NotFound();
            }
            unityOfWork.Trainers.Update(trainer);
            await unityOfWork.SaveAsync();
            return this.mapper.Map<TrainerDTO>(trainer);

        }


    }
}