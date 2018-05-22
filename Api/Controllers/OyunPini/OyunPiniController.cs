using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Nkolay.Web.Api.Service.Interfaces;
using Nkolay.Web.Api.Core.Tdomain.OyunPini;
using Nkolay.Web.Api.ViewModel.Model.OyunPini;
using Nkolay.Web.Api.ViewModel.Request.OyunPini;
using Nkolay.Web.Api.ViewModel.Response.OyunPini;

namespace Nkolay.Web.Api.Controllers
{
    public class OyunPiniController : BaseController
    {
        private readonly IOyunPiniService _oyunPiniService;
        public OyunPiniController(IOyunPiniService oyunPiniService)
        {
            _oyunPiniService = oyunPiniService;
        }

        
        public IActionResult OyunListesi([FromBody]OyunListesiRequestView request)
        //public async Task<IActionResult> OyunListesi([FromBody]OyunListesiRequestView request)
        {
            OyunListesiResponseView response = new OyunListesiResponseView();

            var games = _oyunPiniService.GetGames();

            response.OyunList = new List<Oyun>(games.Count);

            foreach (var game in games)
            {
                var temp = new Oyun();
                temp.Name = game.Name;
                temp.Price = game.Price;

                // Bu şekidle de yapılabilir
                //var temp = new Oyun
                //{
                //    Name = game.Name,
                //    Price = game.Price
                //};

                response.OyunList.Add(temp);
            }

            return Json(response) ;
        }
        
        public string Get()
        {
            var games = _oyunPiniService.GetGames();//.ToList().Where(x=> x.Id == id);

            return games.ToString() + "         ---" ;
        }
        
        public IActionResult OyunEkle([FromBody]OyunEkleRequestView request)
        {
            var oyun = new Game
            {
                Name = request.Name,
                Price = request.Price
            };
            _oyunPiniService.AddGame(request.Name, request.Price);

            return Json(new OyunEkleResponseView());
        }

        // PUT: api/OyunPini/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
