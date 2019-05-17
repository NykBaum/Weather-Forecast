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
			ApiWeatherForecast apiWeatherForecast = new ApiWeatherForecast();

			List<ApiWeatherForecast.Previsao> retorno = apiWeatherForecast.ConsultarTemperaturasPorCidade("Blumenau");

			//Assert
			Assert.IsNotNull(retorno);
		}
	}
}
