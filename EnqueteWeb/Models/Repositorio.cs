using System.Collections.Generic;

namespace EnqueteWeb.Models
{
    public static class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas { get { return respostas; } }

        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }
        static Repositorio()
        {
            respostas.Add(new Resposta() { Nome = "Jessica", Email = "jessica@gmail.com", Sim = true });
            respostas.Add(new Resposta() { Nome = "Terezinha", Email = "terezinha@gmail.com", Sim = false });
            respostas.Add(new Resposta() { Nome = "Jeferson", Email = "jeferson@gmail.com", Sim = true });
            respostas.Add(new Resposta() { Nome = "Juliano", Email = "juliano@gmail.com", Sim = false });
            respostas.Add(new Resposta() { Nome = "Jean", Email = "jean@gmail.com", Sim = true });
            respostas.Add(new Resposta() { Nome = "Julio", Email = "julio@gmail.com", Sim = false });



        }
    }
}
