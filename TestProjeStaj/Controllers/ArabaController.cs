using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArabaController : ControllerBase
    {
        private readonly IArabaService _arabaService;

        public ArabaController(IArabaService arabaService)
        {
            _arabaService = arabaService;
        }

        [HttpPost("[action]")]
        public IActionResult Add([FromBody] Araba araba)
        {
            _arabaService.Add(araba);
            return Ok("İşlem Başarılı");
        }
        [HttpPut("[action]")]
        public IActionResult Update([FromBody] Araba araba)
        {
            
            _arabaService.Update(araba);
            return Ok("Güncelleme İşlemi Başaralı");
        }
        [HttpDelete("[action]")]
        public IActionResult Delete([FromHeader] int id)
        {
            _arabaService.Delete(id);
            return Ok("Silme İşlemi Başaralı");
        }
        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            return Ok(_arabaService.GetAll());

        }
        [HttpGet("[action]")]
        public IActionResult GetByCekiciPlaka(string cekiciPlaka) 
        {
            return Ok(_arabaService.GetByCekiciPlaka(cekiciPlaka));
            
        }
        [HttpGet("[action]")]
        public IActionResult GetAllBySurucuId(int surucuId)
        {
            return Ok(_arabaService.GetAllArabaAndSurucuDtos(surucuId));
        }



    }
}
