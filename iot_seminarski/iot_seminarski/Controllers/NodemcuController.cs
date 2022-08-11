using iot_seminarski.Model;
using iot_seminarski.Servis;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iot_seminarski.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NodemcuController : ControllerBase
    {
        private readonly NodemcuServis servis;
        HttpClient client;
        public NodemcuController(NodemcuServis servis)
        {
            client = new HttpClient();
            this.servis = servis;
        }

        [HttpGet("Temperatura")]
        public async Task<IActionResult> GetTemperaturu() {
            var result = await servis.GetTemperaturu();

            return Ok(result);
        }

        [HttpGet("Klima")]
        public async Task<IActionResult> GetKlimaStanje()
        {
            var result = await servis.GetKlimaStanje();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PromjeniSobnuTemperaturu([FromBody]string temperatura)
        {
            var temperaturaInt = int.Parse(temperatura);

            var result = await servis.PromjeniSobnuTemperaturu(temperaturaInt);

            return Ok(result);

        }

        [HttpGet("On")]
        public async Task<IActionResult> KlimaOn()
        {
            await servis.KlimaON();

            return Ok("Klima je upaljena.");

        }

        [HttpGet("Off")]
        public async Task<IActionResult> KlimaOff()
        {
            await servis.KlimaOff();

            return Ok("Klima je ugašena.");

        }

        [HttpPost("Temperatura/Promjena")]
        public async Task<IActionResult> PromjeniTemperaturu([FromBody] int temperatura)
        {
            await servis.PromjeniTemperaturu(temperatura);

            return Ok("Temperatura je uspješno promjenjena.");

        }

        [HttpGet("Temperatura/Promjena")]
        public async Task<IActionResult> GetPromjeniTemperaturu()
        {
            var respons = await servis.GetPromjeniTemperaturu();

            return Ok(respons);

        }
    }
}
