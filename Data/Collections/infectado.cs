using System;
using MongoDB.Driver.GeoJsonObjectModel;


namespace Api.Data.Collections
{
    public class Infectado
    {
        public Infectado(DateTime dataNascimento, string sexo, string profissao, double latitude, double longitude)
        {
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Profissao = profissao;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }
        
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Profissao {get; set;}
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}