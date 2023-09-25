using CapitalPlacementTask.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CapitalPlacementTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramDetailsController : ControllerBase
    {
        private readonly Models.Container _context;
        private readonly IGenericRepository<ProblemDetails> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ProgramDetailsController(
            Models.Container context,
            IGenericRepository<ProblemDetails> ProgramRepo,
            IUnitOfWork unitOfWork
            )
        {
             
            _context = context;
            _repository = ProgramRepo;
            _unitOfWork = unitOfWork;
        }

        public async Task<ActionResult<IEnumerable<ProgramDetails>>> GetProgramDetails()
        {
            var programDetails = await _repository.ListAllAsync();
            return Ok(programDetails);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProgramDetails>> GetProgramDetails(int id)
        {
            var programDetail = await _repository.GetByIdAsync(id);

            if (programDetail == null)
            {
                return NotFound();
            }

            return Ok(programDetail);
        }

        [HttpPost]
        public async Task<ActionResult<ProgramDetails>> PostProgramDetails(ProgramDetails programDetail)
        {
            var addedProgramDetail = await _repository.AddAsync(programDetail);
            return CreatedAtAction("GetProgramDetails", new { id = addedProgramDetail.Id }, addedProgramDetail);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProgramDetails(int id, ProgramDetails programDetail)
        {
            if (id != programDetail.Id)
            {
                return BadRequest();
            }

            try
            {
                await _repository.UpdateEntityAsync(programDetail);
            }
            catch
            {
                if (!ProgramDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgramDetails(int id)
        {
            var programDetail = await _repository.GetByIdAsync(id);
            if (programDetail == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync(programDetail);

            return NoContent();
        }

        private bool ProgramDetailExists(int id)
        { 
            if ( _repository.GetByIdAsync(id) == null)
                return false;
            return true;
        }
    }
}
