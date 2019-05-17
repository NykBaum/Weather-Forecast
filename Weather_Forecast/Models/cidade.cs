using System.ComponentModel.DataAnnotations;

namespace Weather_Forecast.Models
{
	[MetadataType(typeof(CidadeHelper))]
	public partial class cidade { }

	public class CidadeHelper
	{
		[Display(Name = "Código", Description = "Código da cidade")]
		public int codigo { get; set; }

		[Display(Name = "Nome", Description = "Nome da cidade")]
		public string nome { get; set; }

		[Display(Name = "UF", Description = "Estado")]
		public string uf { get; set; }

		[Display(Name = "País", Description = "Nome do País")]
		public string pais { get; set; }
	}
}