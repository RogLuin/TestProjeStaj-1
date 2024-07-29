using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArabaSurucuController : ControllerBase
    {
        private readonly IArabaSurucuService _arabaSurucuService;

        public ArabaSurucuController(IArabaSurucuService arabaSurucuService)
        {
            _arabaSurucuService = arabaSurucuService;
        }

        [HttpPost("[action]")]
        public IActionResult Add([FromBody] ArabaSurucu arabaSurucu)
        {
            _arabaSurucuService.Add(arabaSurucu);
            return Ok("İşlem Başarılı");
        }

        [HttpPut("[action]")]
        public IActionResult Update([FromBody] ArabaSurucu arabaSurucu)
        {

            _arabaSurucuService.Update(arabaSurucu);
            return Ok("Güncelleme İşlemi Başaralı");
        }

        [HttpDelete("[action]")]
        public IActionResult Delete([FromHeader] int id)
        {
            _arabaSurucuService.Delete(id);
            return Ok("Silme İşlemi Başaralı");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            return Ok(_arabaSurucuService.GetAll());

        }
        [HttpGet("[action]")]
        public IActionResult GetBySurucuId(int surucuId )
        {
            return Ok(_arabaSurucuService.GetByArabaSurucuId(surucuId));

        }
    }
    }

