namespace Gerenciador.Domain.Entities
{
    public class Participante
    {
        public string Cpf { get; set; }
        public string Nome {  get; set; }
        public List<int> Agenda { get; set; }

        public Participante(string cpf, string nome)
        {
            Cpf = cpf;
            Nome = nome;
            Agenda = new List<int>();
        }

        public void RegistrarEmEvento(int eventoId)
        {
            Agenda.Add(eventoId);
        }
    }
}
