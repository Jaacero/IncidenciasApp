using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.UnityOfWork;
using API.DTOs;
using AutoMapper;
using Core.DTOS;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Controllers
{
    [ApiController]
    [Route("api/controler/Incidencias")]
    public class IncidenciaController
    {
        private readonly IUnityOfWork _unitofwork;
        private readonly IMapper _mapper;

        public IncidenciaController(IUnityOfWork unitofwork,IMapper mapper)
        {
            _unitofwork = unitofwork;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task Postincidencias(IncidenciaDTO[] incidenciasDTOs)
        {
            var incidencias = _mapper.Map<Incidencia[]>(incidenciasDTOs);
             _unitofwork.Incidencias.AddRange(incidencias);
             await _unitofwork.SaveAsync();          
        }
        [HttpGet]
        public async Task<IEnumerable<Incidencia>> GetIncidencias()
        {
            return await _unitofwork.Incidencias.GetAllIncidenciasAsync();
            
        }
        [HttpGet("getByCategoria/{idCategoria:int}")]
        public async Task<IEnumerable<Incidencia>> GetIncidenciaByCategoria(int categoriaId)
        {
            return await _unitofwork.Incidencias.GetIncidinciaByCategoria(categoriaId);   
        }
        [HttpGet("getByTrainer/{idTrainer:int}")]
        public async Task<IEnumerable<Incidencia>> GetInidenciasByTrainerId(int idTrainer)
        {
            return await _unitofwork.Incidencias.GetInidenciasByTrainer(idTrainer);
        }
       
    }
}