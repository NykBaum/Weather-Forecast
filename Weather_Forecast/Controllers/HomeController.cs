using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weather_Forecast.Controllers
{
    public class HomeController : Controller
    {
		BD_WEATHERFORECASTEntities db = new BD_WEATHERFORECASTEntities();
		string msgErro;

		// GET: Home
		public ActionResult Index()
        {
			var lista = db.cidade.ToList();

			return View(lista);

		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(cidade cidadeNova)
		{
			if (ApiWeatherForecast.ExisteInformacoesParaCidade(cidadeNova.nome))
			{
				db.cidade.Add(cidadeNova);
				db.SaveChanges();
			}
			else
			{
				msgErro = "Não temos dados de previsão do tempo para esta cidade.";
			}
		
			return View("Index");
		}
	}
}