using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurucuController : ControllerBase
    {
        private readonly ISurucuService _surucuService;

        public SurucuController(ISurucuService surucuService)
        {
            _surucuService = surucuService;
        }

        [HttpPost("[action]")]
        public IActionResult Add([FromBody] Surucu surucu)
        {
            _surucuService.Add(surucu);
            return Ok("İşlem Başarılı");
        }
        [HttpPut("[action]")]
        public IActionResult Update([FromBody] Surucu entity)
        {

            _surucuService.Update(entity);
            return Ok("Güncelleme İşlemi Başaralı");
        }

        [HttpDelete("[action]")]
        public IActionResult Delete([FromHeader] int id)
        {
            _surucuService.Delete(id);
            return Ok("Silme İşlemi Başaralı");
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            return Ok(_surucuService.GetAll());
        }
        [HttpGet("[action]")]
        public IActionResult GetBySurucuId(int Surucuid)
        {
            return Ok(_surucuService.GetBySurucuId(Surucuid));

        }
        [HttpGet("[action]")]
        public IActionResult GetAllByFirmaId(int firmaId)
        {
            return Ok(_surucuService.GetAllByFirmaId(firmaId));
        }
        [HttpGet("[action]")]
        public IActionResult GetAllByArabaId(int arabaId)
        {
            return Ok(_surucuService.GetAllByArabaId(arabaId));
        }

    }
}
