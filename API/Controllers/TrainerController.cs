using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/controler/tariner")]
    public class TrainerController : ControllerBase
    {
        private readonly IUnityOfWork unityOfWork;

        public TrainerController(IUnityOfWork unityOfWork)
        {
            this.unityOfWork = unityOfWork;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trainer>>> GetTrainers(){
            var actores = await unityOfWork.Trainers.
            GetAllTrainersAsync();
            return Ok(actores);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Trainer>> GetById(int id){
            var actor = await unityOfWork.Trainers.GetTrainerByIdAsync(id);
            if(actor is null){
                return NotFound();
            }
            return Ok(actor);
        }
    }
}