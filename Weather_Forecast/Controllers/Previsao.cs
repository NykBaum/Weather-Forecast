using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Weather_Forecast.Controllers
{
    [MetadataType(typeof(PrevisaoHelper))]
    public class Previsao
    {
        public string DataHora;
        public string TemperaturaMinima;
        public string TemperaturaMaxima;
        public string Umidade;
        public string Descricao;
        public string Icone;
    }

    public class PrevisaoHelper
    {
        [Display(Name = "Data/Hora", Description = "Data/Hora")]
        public string DataHora;

        [Display(Name = "Mínima", Description = "Temperatura mínima")]
        public string TemperaturaMinima;

        [Display(Name = "Máxima", Description = "Temperatura máxima")]
        public string TemperaturaMaxima;

        [Display(Name = "Umidade", Description = "Umidade relativa do ar")]
        public string Umidade;

        [Display(Name = "Data/Hora", Description = "Data/Hora")]
        public string Descricao;
    }
}