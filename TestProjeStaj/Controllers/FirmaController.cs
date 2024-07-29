using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaController : ControllerBase
    {
        private readonly IFirmaService _firmaService;

        public FirmaController(IFirmaService firmaService)
        {
            _firmaService = firmaService;
        }

        [HttpPost("[action]")]
        public IActionResult Add([FromBody] Firma firma)
        {
            _firmaService.Add(firma);
            return Ok("İşlem Başarılı");
        }
        [HttpPut("[action]")]
        public IActionResult Update([FromBody] Firma firma)
        {

            _firmaService.Update(firma);
            return Ok("Güncelleme İşlemi Başaralı");
        }
        [HttpDelete("[action]")]
        public IActionResult Delete([FromHeader] int id)
        {
            _firmaService.Delete(id);
            return Ok("Silme İşlemi Başaralı");
        }
        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            return Ok(_firmaService.GetAll());

        }
        [HttpGet("[action]")]
        public IActionResult GetByFirmaId(int id)
        {
            return Ok(_firmaService.GetByFirmaId(id));

        }
    }
}
