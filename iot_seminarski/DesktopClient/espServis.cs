using Flurl.Http;
using iot_seminarski.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient
{
    public class espServis
    {
        private string path = "http://iot.p2098.app.fit.ba/Nodemcu";

        
        public espServis(){}

        public async Task<int> GetTemperaturu()
        {

            var data = await (path+"/Temperatura").GetJsonAsync<int>();

            return data;
        }


        public async Task<bool> KlimaON()
        {
            await (path+"/On").GetAsync();

            return true;

        }

        public async Task<bool> PromjeniTemperaturu(int temperatura)
        {
            try
            {
                await (path + "/Temperatura/Promjena").PostJsonAsync(temperatura);

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public async Task<bool> KlimaOff()
        {
            await (path + "/Off").GetAsync();

            return true;
        }

        public async Task<bool> GetStanjeKlime() {

            var respons = await (path + "/Klima").GetJsonAsync<bool>();

            return respons;
        }
    }
}
