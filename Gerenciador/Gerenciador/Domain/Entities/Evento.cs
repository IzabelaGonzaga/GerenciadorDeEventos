namespace Gerenciador.Domain.Entities
{
    public class Evento
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime Data { get; set; }
        public string? Local { get; set; }
        public int CapacidadeDeParticipantes { get; set; }
        public EnumStatus Status { get; set; }
        public DateTime? Retorno { get; set; }

        public Evento(string? nome, DateTime data, string? local, int capacidadeDeParticipantes)
        {
            Id = new Random().Next();
            Nome = nome;
            Data = data;
            Local = local;
            CapacidadeDeParticipantes = capacidadeDeParticipantes;
            Status = EnumStatus.Agendado;
        }

        public virtual void Iniciar()
        {
            Status = EnumStatus.Iniciado;
        }

        public virtual void Pausar(DateTime horarioRetorno)
        {
            Status = EnumStatus.Pausado;
            Retorno = horarioRetorno;
        }

        public virtual void Concluir()
        {
            Status = EnumStatus.Concluido;
        }

        public virtual void Cancelar()
        {
            Status = EnumStatus.Cancelado;
        }

    }
}
