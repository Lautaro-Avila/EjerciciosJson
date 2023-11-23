using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson.MiEjercicio2
{
    internal class User
    {

        public string usuario { get; set; }

        [JsonPropertyName("amigos_usuario")]
        public string[] amigos { get; set; }

        [JsonPropertyName("notificaciones_usuario")]
        public bool notificaciones { get; set; }
    }
}
