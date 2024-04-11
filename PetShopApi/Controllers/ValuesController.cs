using Microsoft.AspNetCore.Mvc;
using PetShopApi.Models;


namespace PetShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {

        [HttpGet("ConsultaPetShop")]
        public ActionResult<PetShop> CalcularPreco(string dia, int cachorroPequeno, int cachorroGrande)
        {
            DateTime parsedDate;
            if (!DateTime.TryParseExact(dia, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                return BadRequest("Formato de data inválido. Use o formato dd/MM/yyyy.");
            }
            double precoPet1, precoPet2, precoPet3;
            var shop1 = new PetShop();
            shop1.name = "Meu Canino Feliz";
            shop1.distance = 2;
            shop1.smallDogPrice = 20;
            shop1.largeDogPrice = 40;
            shop1.smallDogWeekend = 24;
            shop1.largeDogWeekend = 48;

            var shop2 = new PetShop();
            shop2.name = "Vai Rex";
            shop2.distance = 1.7;
            shop2.smallDogPrice = 15;
            shop2.largeDogPrice = 50;
            shop2.smallDogWeekend = 20;
            shop2.largeDogWeekend = 55;

            var shop3 = new PetShop();
            shop3.name = "ChowChawgas";
            shop3.distance = 0.8;
            shop3.smallDogPrice = 30;
            shop3.largeDogPrice = 45;
            shop3.smallDogWeekend = 30;
            shop3.largeDogWeekend = 45;

            if (parsedDate.DayOfWeek == DayOfWeek.Saturday || parsedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                precoPet1 = shop1.PrecoFimSemana(cachorroPequeno, cachorroGrande);
                precoPet2 = shop2.PrecoFimSemana(cachorroPequeno, cachorroGrande);
                precoPet3 = shop3.PrecoFimSemana(cachorroPequeno, cachorroGrande);

            }
            else
            {
                precoPet1 = shop1.PrecoNormal(cachorroPequeno, cachorroGrande);
                precoPet2 = shop2.PrecoNormal(cachorroPequeno, cachorroGrande);
                precoPet3 = shop3.PrecoNormal(cachorroPequeno, cachorroGrande);

            }
            var petshopMaisBarato = shop1;
            double precoMaisBarato = precoPet1;

            if (precoPet2 < precoMaisBarato)
            {
                petshopMaisBarato = shop2;
                precoMaisBarato = precoPet2;
            }
            if (precoPet3 < precoMaisBarato)
            {
                petshopMaisBarato = shop3;
                precoMaisBarato = precoPet3;
            }
            return Ok(new
            {
                Petshop = petshopMaisBarato.name,
                Preco = precoMaisBarato,
            });
        }
    }
}