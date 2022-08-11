using Flurl.Http;
using iot_seminarski.Model;

namespace iot_seminarski.Servis
{
    public class NodemcuServis
    {
        string path = "https://iotseminarski-e488c-default-rtdb.europe-west1.firebasedatabase.app/temperaturaProstorije.json";
        string pathKlima = "https://iotseminarski-e488c-default-rtdb.europe-west1.firebasedatabase.app/klima.json";
        string pathTempPromjena = "https://iotseminarski-e488c-default-rtdb.europe-west1.firebasedatabase.app/temperaturaPromjene.json";


        public NodemcuServis()
        {            
        }


        public async Task<int> GetTemperaturu() {

            var respons = await path.GetJsonAsync<int>();

            return respons;
        }

        public async Task<bool> GetKlimaStanje()
        {

            var respons = await pathKlima.GetJsonAsync<bool>();

            return respons;
        }

        public async Task<string> PromjeniSobnuTemperaturu(int temperatura)
        {
            var obj = new Temperatura() { 
                sobnaTemperatura = temperatura,
            };

            var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            
            var data = await path.PutJsonAsync(temperatura);

            return jsonData;
        }

        public async Task<bool> KlimaON()
        {
            await pathKlima.PutJsonAsync(true);

            return true;

        }

        public async Task<bool> KlimaOff()
        {
            await pathKlima.PutJsonAsync(false);

            return true;
        }

        public async Task<bool> PromjeniTemperaturu(int promjena)
        {
            await pathTempPromjena.PutJsonAsync(promjena);

            return true;
        }

        public async Task<int> GetPromjeniTemperaturu()
        {
            var respons = await pathTempPromjena.GetJsonAsync<int>();

            return respons;
        }
    }
}
