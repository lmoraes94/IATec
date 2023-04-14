using Microsoft.AspNetCore.Mvc;
using projectAPI.Models;
using System;

namespace projectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {


        private readonly ILogger<CadastroController> _logger;

        public CadastroController(ILogger<CadastroController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<CadastroModel> novoCadastro = new List<CadastroModel>();
            novoCadastro.Add(new CadastroModel(1, "Leonardo", 10));
            novoCadastro.Add(new CadastroModel(2, "Cecilia", 26));
            novoCadastro.Add(new CadastroModel(3, "Camila", 27));
            novoCadastro.Add(new CadastroModel(4, "Francisco", 52));
            return Ok(novoCadastro);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            List<CadastroModel> novoCadastro = new List<CadastroModel>();
            novoCadastro.Add(new CadastroModel(1, "Leonardo", 10));
            novoCadastro.Add(new CadastroModel(2, "Cecilia", 26));
            novoCadastro.Add(new CadastroModel(3, "Camila", 27));
            novoCadastro.Add(new CadastroModel(4, "Francisco", 52));

            var resposta = novoCadastro.FirstOrDefault(i => i.Id == id);
            return Ok(resposta);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCadastro(int id)
        {
            
             var personToDelete = Get(id);
            
            if (id == 0)
            {
                return NotFound("Id do cadastro não encontrado");
            }
            return Ok("Cadastro deletado");
        }
        [HttpPost]
        public IActionResult Create([FromBody] CadastroModel model)
        {
            model.Id = 2;
            return StatusCode(StatusCodes.Status201Created, model.Id);

        }
        [HttpPut("{id:int}")]
        public IActionResult Update([FromRoute]int id, [FromBody]CadastroModel model)
        {
            if (id == 0)
            {
                return BadRequest("Este Id não pode ser atualizado");

            }
            return Ok(model);
        }
        [HttpPatch("{id:int}")]
        public IActionResult Update2([FromRoute] int id, [FromBody] CadastroModel model)
        {
            if (id == 0)
            {
                return BadRequest("Este Id não pode ser atualizado");

            }
            return Ok(model);
        }
    }
}