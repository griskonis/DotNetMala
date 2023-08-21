using Microsoft.AspNetCore.Mvc;
using PetCareCliAPI.Helpers;
using PetCareCliAPI.Interfaces;
using PetCareCliAPI.Models.Reponse;
using System.Diagnostics;

namespace PetCareCliAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetCareController : ControllerBase
    {
        private readonly ILogger<PetCareController> _logger;
        private readonly IAPIHelper _apiHelper;
        private readonly ITutor _itutor;
        private readonly IPet _pet;
        private readonly ISpecialty _specialty;
        private readonly IUnit _unit;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="itutor"></param>
        /// <param name="apiHelper"></param>
        public PetCareController(ILogger<PetCareController> logger, IAPIHelper apiHelper, ITutor itutor, IPet pet, ISpecialty specialty, IUnit unit)
        {
            _logger = logger;
            _itutor = itutor;
            _apiHelper = apiHelper;
            _pet = pet;
            _specialty = specialty;
            _unit = unit;
        }

        /// <summary>
        /// Retorna lista de tutores
        /// </summary>
        /// <returns>tutors</returns>
        [HttpGet("/getTutors")]
        public async Task<IActionResult> GetTutors()
        {
            StackFrame stackFrame = new StackFrame(3);
            try
            {
                _logger.LogInformation(string.Concat(ApiHelper.START_OF_SERVICE, stackFrame.GetMethod()?.Name));
                var tutors = await _itutor.GetTutorsAsync();

                _logger.LogInformation(string.Concat(ApiHelper.END_OF_SERVICE, stackFrame.GetMethod()?.Name));
                return tutors.Any() ? Ok(tutors) : NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
                throw;
            }
            
        }

        /// <summary>
        /// Retorna tutor
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns>tutor</returns>
        [HttpGet("/getTutor")]
        public async Task<IActionResult> GetTutor(string cpf)
        {
            StackFrame stackFrame = new StackFrame(3);
            try
            {
                _logger.LogInformation(string.Concat(ApiHelper.START_OF_SERVICE, stackFrame.GetMethod()?.Name));
                if (string.IsNullOrEmpty(cpf))
                    return NotFound(ApiHelper.CPF_NOT_INFORMED);

                string formatCPF = _apiHelper.FormatForNoDotCPF(cpf);
                var tutor = await _itutor.GetTutorAsync(formatCPF);
                _logger.LogInformation(string.Concat(ApiHelper.END_OF_SERVICE, stackFrame.GetMethod()?.Name));
                return tutor != null ? Ok(tutor) : NotFound(ApiHelper.TUTOR_NOT_FOUND);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
                throw;
            }
        }

        /// <summary>
        /// Retorna lista de pets
        /// </summary>
        /// <returns>Pets</returns>
        [HttpGet("/pets")]
        public async Task<IActionResult> GetPets()
        {
            StackFrame stackFrame = new StackFrame(3);
            try
            {
                _logger.LogInformation(string.Concat(ApiHelper.START_OF_SERVICE, stackFrame.GetMethod()?.Name));
                var pets = await _pet.GetPetsAsync();

                _logger.LogInformation(string.Concat(ApiHelper.END_OF_SERVICE, stackFrame.GetMethod()?.Name));
                return pets.Any() ? Ok(pets) : NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
                throw;
            }
        }

        /// <summary>
        /// Retorna Pet
        /// </summary>
        /// <returns>Pet</returns>
        [HttpGet("/pet")]
        public async Task<IActionResult> GetPet(int codigo)
        {
            StackFrame stackFrame = new StackFrame(3);
            try
            {
                _logger.LogInformation(string.Concat(ApiHelper.START_OF_SERVICE, stackFrame.GetMethod()?.Name));
                if (codigo < 1)
                    return NotFound(ApiHelper.COD_PET_NOT_INFORMED);

                var pet = await _pet.GetPetAsync(codigo);
                _logger.LogInformation(string.Concat(ApiHelper.END_OF_SERVICE, stackFrame.GetMethod()?.Name));
                return pet != null ? Ok(pet) : NotFound(ApiHelper.PET_NOT_FOUND);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
                throw;
            }
        }

        /// <summary>
        /// Retorna Especialidades
        /// </summary>
        /// <returns></returns>
        [HttpGet("/Specialtys")]
        public async Task<IActionResult> GetSpecialtys()
        {
            StackFrame stackFrame = new StackFrame(3);
            try
            {
                _logger.LogInformation(string.Concat(ApiHelper.START_OF_SERVICE, stackFrame.GetMethod()?.Name));
                var specialty = await _specialty.GetSpecialtysAsync();

                _logger.LogInformation(string.Concat(ApiHelper.END_OF_SERVICE, stackFrame.GetMethod()?.Name));
                return specialty.Any() ? Ok(specialty) : NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
                throw;
            }
        }

        /// <summary>
        /// Retorna Especialidade
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/Specialty")]
        public async Task<IActionResult> GetSpecialty(int id)
        {
            StackFrame stackFrame = new StackFrame(3);
            try
            {
                _logger.LogInformation(string.Concat(ApiHelper.START_OF_SERVICE, stackFrame.GetMethod()?.Name));
                if (id < 1)
                    return NotFound(ApiHelper.COD_SPECIALTY_NOT_INFORMED);

                var specialty = await _specialty.GetSpecialtyAsync(id);
                _logger.LogInformation(string.Concat(ApiHelper.END_OF_SERVICE, stackFrame.GetMethod()?.Name));
                return specialty != null ? Ok(specialty) : NotFound(ApiHelper.SPECIALTY_NOT_FOUND);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
                throw;
            }
        }

        /// <summary>
        /// Retorna Unidades(empresa)
        /// </summary>
        /// <returns></returns>
        [HttpGet("/units")]
        public async Task<IActionResult> GetUnits()
        {
            StackFrame stackFrame = new StackFrame(3);
            try
            {
                _logger.LogInformation(string.Concat(ApiHelper.START_OF_SERVICE, stackFrame.GetMethod()?.Name));
                var unit = await _unit.GetUnitsAsync();

                _logger.LogInformation(string.Concat(ApiHelper.END_OF_SERVICE, stackFrame.GetMethod()?.Name));
                return unit.Any() ? Ok(unit) : NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
                throw;
            }
        }

        /// <summary>
        /// Retorna Unidade(empresa)
        /// </summary>
        /// <param name="idEmp"></param>
        /// <returns></returns>
        [HttpGet("/unit")]
        public async Task<IActionResult> GetUnit(int idEmp)
        {
            StackFrame stackFrame = new StackFrame(3);
            try
            {
                _logger.LogInformation(string.Concat(ApiHelper.START_OF_SERVICE, stackFrame.GetMethod()?.Name));
                if (idEmp < 1)
                    return NotFound(ApiHelper.COD_UNIT_NOT_INFORMED);

                var unit = await _unit.GetUnitAsync(idEmp);
                _logger.LogInformation(string.Concat(ApiHelper.END_OF_SERVICE, stackFrame.GetMethod()?.Name));
                return unit != null ? Ok(unit) : NotFound(ApiHelper.UNIT_NOT_FOUND);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
                throw;
            }
        }
    }
}
