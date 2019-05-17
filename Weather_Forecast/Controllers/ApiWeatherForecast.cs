using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Weather_Forecast.Controllers
{
	public class ApiWeatherForecast
	{
		const string API_KEY = "a663946e108d5bfab8709a88915d94f3";

		const string URL_API_WEATHER = "https://api.openweathermap.org/data/2.5/forecast";
		const string PARAM_LANG = "&lang=pt";
		const string PARAM_UNIT = "&units=metric";

		public List<Previsao> ConsultarTemperaturasPorCidade(string cidade)
		{
			using (WebClient webClient = new WebClient())
			{
				try
				{
					string retorno = webClient.DownloadString(URL_API_WEATHER + "?q=" + cidade + PARAM_LANG + PARAM_UNIT + "&appid=" + API_KEY);
					JObject retornoJson = JObject.Parse(retorno);

					List<Previsao> previsoes = new List<Previsao>();

					foreach (var item in retornoJson["list"].ToList())
					{
						Previsao previsao = new Previsao
						{
							DataHora = item["dt_txt"].ToString(),
							TemperaturaMinima = (item["main"])["temp_min"].ToString(),
							TemperaturaMaxima = (item["main"])["temp_max"].ToString(),
							Umidade = (item["main"])["humidity"].ToString(),
							Descricao = ((item["weather"])[0])["description"].ToString()
						};

						previsoes.Add(previsao);
					}

					return previsoes;
				}
				catch (Exception)
				{
					return null;
				}
			}
		}

		public static bool ExisteInformacoesParaCidade(string cidade)
		{
			using (WebClient webClient = new WebClient())
			{
				try
				{
					string retorno = webClient.DownloadString(URL_API_WEATHER + "?q=" + cidade + PARAM_LANG + PARAM_UNIT + "&appid=" + API_KEY);
					JObject retornoJson = JObject.Parse(retorno);

					if ((string)retornoJson["cod"] == "404")
						return false;
				}
				catch (Exception)
				{
					return false;
				}
			}

			return true;
		}

		public class Previsao
		{
			public string DataHora;
			public string TemperaturaMinima;
			public string TemperaturaMaxima;
			public string Umidade;
			public string Descricao;
		}
	}
}