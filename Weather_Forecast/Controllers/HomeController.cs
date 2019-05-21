using System.Linq;
using System.Web.Mvc;

namespace Weather_Forecast.Controllers
{
    public class HomeController : Controller
    {
        BD_WEATHERFORECASTEntities1 db = new BD_WEATHERFORECASTEntities1(); 
        string msg_erro;

        // GET: Home
        public ActionResult Index()
        {
			return View(db.cidade.ToList());
		}

		public ActionResult Create()
		{
            return View();
		}

        public ActionResult Previsao(string cidade)
        {
            if (string.IsNullOrEmpty(cidade))
            {
                return RedirectToAction("Index");
            }

            return View(ApiWeatherForecast.ConsultarTemperaturasPorCidade(cidade));
        }

		[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(cidade cidadeNova)
		{
            msg_erro = "Cidade \"" + cidadeNova.nome + "\" salva com sucesso!";

            if (db.cidade.Count(cid => cid.nome == cidadeNova.nome) > 0)
            {
                msg_erro = "Cidade \"" + cidadeNova.nome + "\" já cadastrada!";
            }
            else if (ApiWeatherForecast.ExisteInformacoesParaCidade(cidadeNova.nome))
			{
                try
                { 
                    cidadeNova.codigo = db.cidade.Max(c => c.codigo) + 1;
                }
                catch
                {
                    cidadeNova.codigo = 0;
                }
				db.cidade.Add(cidadeNova);
				db.SaveChanges();
			}
			else
			{
                msg_erro = "Não temos dados de previsão do tempo para esta cidade. \nCidade não cadastrada!";
            }

            return Json(new { mensagem = msg_erro }, JsonRequestBehavior.AllowGet);
        }

    }
}