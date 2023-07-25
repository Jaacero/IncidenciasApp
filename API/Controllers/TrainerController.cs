using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using API.DTOs;
using AutoMapper;
using Infrastructure.UnityOfWork;

namespace API.Controllers
{
    [ApiController]
    [Route("api/controler/trainer")]
    public class TrainerController : ControllerBase
    {
        private readonly IUnityOfWork unityOfWork;
        private readonly IMapper mapper;

        public TrainerController(IUnityOfWork unityOfWork, IMapper mapper)
        {
            this.unityOfWork = unityOfWork;
            this.mapper = mapper;
        }
        [HttpGet]
        [ApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Trainer>>> GetTrainers()
        {
            var actores = await unityOfWork.Trainers.
            GetAllTrainersAsync();
            return Ok(actores);
        }
        [HttpGet("ById/{id}")]
        [ApiVersion("1.0")]
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

        [HttpGet("getByName/{name}")]
        [ApiVersion("1.0")]
        public async Task<IEnumerable<Trainer>> GetTrainerByName(string name)
        {
            return await unityOfWork.Trainers.GetTrainersByName(name);
        }

        [HttpPost]
        [ApiVersion("1.0")]
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
        [ApiVersion("1.0")]
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
        [ApiVersion("1.0")]
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
        [ApiVersion("1.0")]
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