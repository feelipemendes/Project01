namespace Projeto01.Application.Commands
{
    public class ContatoUpdateCommand
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
    }
}
