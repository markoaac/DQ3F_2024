using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_IV_Formularios
{
    public class Ruta
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("repartidor")]
        public string? Repartidor { get; set; }
        [BsonElement("fecha")]
        public string? Fecha { get; set; }
        [BsonElement("paquetes_entrega")]
        public List<Paquete> Paquetes { get; set; }
    }
}
