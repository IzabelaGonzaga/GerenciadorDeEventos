
namespace Gerenciador.Domain.Entities
{
    public class Conferencia : Evento
    {
        //criar lista de atividades

        public Conferencia(string? nome, DateTime data, string? local, int capacidadeDeParticipantes) : base(nome, data, local, capacidadeDeParticipantes)
        {
        }

        //criar o método para incrementar lista de atividades

    }
}
