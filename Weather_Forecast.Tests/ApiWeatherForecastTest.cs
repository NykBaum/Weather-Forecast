using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Weather_Forecast.Controllers;

namespace Weather_Forecast.Tests
{
	[TestClass]
	public class ApiWeatherForecastTest
	{
		[TestMethod]
		public void ConsultarTemperaturasPorCidade_PassandoUmaCidadeValida()
		{
			List<Previsao> retorno = ApiWeatherForecast.ConsultarTemperaturasPorCidade("Blumenau");

			//Assert
			Assert.IsNotNull(retorno);
		}
	}
}
