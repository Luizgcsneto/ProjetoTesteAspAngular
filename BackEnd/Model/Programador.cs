namespace BackEnd.Model
{
    public class Programador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CursoSuperior {get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Linkedin { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Portfolio { get; set; }
        public string PretensaoSalarial { get; set; }
        public bool HoraAteQuatro { get; set; }
        public bool HoraQuatroAteSeis { get; set; }
        public bool HoraSeisAteOito { get; set; }
        public bool HoraAcimaOito { get; set; }
        public bool HorarioPelaManha { get; set; }
        public bool HorarioPelaTarde { get; set; }
        public bool HorarioPelaNoite { get; set; }
        public bool HorarioComercial { get; set; }
        public bool HorarioPelaMadrugada { get; set; }
        public bool HorarioFinalDeSemana { get; set; }
        public bool DisponibilidadeViagem { get; set; }
        public string BancoNome { get; set; }
        public bool ContaPoupanca { get; set; }
        public bool ContaCorrente { get; set; }
        public string BancoAgencia { get; set; }
        public string BancoNumConta { get; set; }
        public string ProjetoCRUDlink { get; set; }

    }
}