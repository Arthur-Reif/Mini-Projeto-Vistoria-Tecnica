namespace Mini_Projeto_Vistoria_Tecnica.Modelos;
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }
        public Carro(string marca, string modelo, int ano, double km, int quantidadePortas) : base(marca, modelo, ano, km)
        {
            this.QuantidadePortas = quantidadePortas;
        }

        public override List<string> ObterChecklistObrigatorio()
        {
            List<string> checklist = base.ObterChecklistObrigatorio();
            checklist.Add("Estepe e Macaco");
            checklist.Add("Triângulo de Sinalização");
            checklist.Add("Ar Condicionado Funcional");
            return checklist;
        }
    }

