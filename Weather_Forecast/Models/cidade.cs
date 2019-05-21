using System.ComponentModel.DataAnnotations;

namespace Weather_Forecast
{
	[MetadataType(typeof(CidadeHelper))]
	public partial class cidade { }

	public class CidadeHelper
	{
		[Display(Name = "Código", Description = "Código da cidade")]
		public int codigo { get; set; }

		[Display(Name = "Nome", Description = "Nome da cidade")]
		public string nome { get; set; }
	}
}