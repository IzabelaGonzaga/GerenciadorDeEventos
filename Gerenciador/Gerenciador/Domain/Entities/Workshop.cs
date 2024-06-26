namespace Gerenciador.Domain.Entities
{
    public class Workshop : Evento
    {
        public Workshop(string? nome, DateTime data, string? local, int capacidadeDeParticipantes) : base(nome, data, local, capacidadeDeParticipantes)
        {
        }
    }
}
