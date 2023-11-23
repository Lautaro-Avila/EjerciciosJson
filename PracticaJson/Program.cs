using PracticaJson.MiEjercicio3;
using PracticaJson.Solutions.Ejercicio_1;
using System.Text.Json;

namespace PracticaJson
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            #region Carga del directorio de los JSON
            string pathEjercicioUno = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio1.json");
            string pathEjercicioDos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio2.json");
            string pathEjercicioTres = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio3.json");
            string pathEjercicioCuatro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio4.json");
            #endregion

            string ejercicio1 = File.ReadAllText(pathEjercicioUno);

            string ejercicio2 = File.ReadAllText(pathEjercicioDos);

            string ejercicio3 = File.ReadAllText(pathEjercicioTres);

            string ejercicio4 = File.ReadAllText(pathEjercicioCuatro);



         //                                   ---------------------------------------EJERCICIO 1 ------------------------------------------------
           
            
            var options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            };

            /*Persona2 persona2 = JsonSerializer.Deserialize<Persona2>(ejercicio1, options )!;

            string MiPerosnaJson = JsonSerializer.Serialize(persona2);


            Console.WriteLine(persona2.nombre);
            Console.WriteLine(persona2.edad);
            Console.WriteLine(persona2.pais);
            Console.WriteLine(persona2.activo);
            Console.WriteLine(MiPerosnaJson);*/

            //                                ---------------------------------------EJERCICIO 2 ------------------------------------------------

            /*User usuario1 = JsonSerializer.Deserialize<User>(ejercicio2)!;

            string UserJson = JsonSerializer.Serialize(usuario1);

            Console.WriteLine(usuario1.usuario);
            Console.WriteLine("");

            foreach (string amigos in usuario1.amigos) 
            
            Console.WriteLine(amigos);
            Console.WriteLine("");
            Console.WriteLine(usuario1.notificaciones);
            Console.WriteLine("");
            Console.WriteLine(UserJson);*/



            //                                ---------------------------------------EJERCICIO 3 ------------------------------------------------




            General estadistica = JsonSerializer.Deserialize<General>(ejercicio3, options);
        
        }



    }


}


    
    