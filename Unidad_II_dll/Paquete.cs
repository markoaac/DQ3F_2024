using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Unidad_II_dll
{
    public class Paquete
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("idpaquete")]
        public string? IdPaquete { get; set; }
        [BsonElement("direccion")]
        public string? Direccion { get; set; }
        [BsonElement("comprador")]
        public string? Comprador { get; set; }
        [BsonElement("peso")]
        public decimal Peso { get; set; }
        [BsonElement("vendedor")]
        public string? Vendedor { get; set; }
        [BsonElement("prioridad")]
        public string? Prioridad { get; set; }
        [BsonElement("estatus")]
        public string? Estatus { get; set; }
    }
}
