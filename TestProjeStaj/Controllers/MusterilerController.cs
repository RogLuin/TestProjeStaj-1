using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusterilerController : ControllerBase
    {
        private readonly IMusteriService _musteriService;

        public MusterilerController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }
        [HttpPost("[action]")]
        public IActionResult Add([FromBody] Musteri musteri)
        {
            _musteriService.Add(musteri);
            return Ok("İşlem Başarılı");
        }
        [HttpGet("[action]")]
        public IActionResult GetAllMusteri(int musteriId)
        {
            return Ok(_musteriService.GetByMusteriId(musteriId));

        }
    }
}
