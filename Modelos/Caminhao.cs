namespace Mini_Projeto_Vistoria_Tecnica.Modelos;

public class Caminhao : Veiculo
{
    public double QuantidadeEixos { get; set; }
    public double CapacidadeCargaToneladas { get; set; }
    public Caminhao(string marca, string modelo, int ano, double km, double quantidadeEixos, double capacidadeCargaToneladas) : base(marca, modelo, ano, km)
    {
        this.QuantidadeEixos = quantidadeEixos;
        this.CapacidadeCargaToneladas = capacidadeCargaToneladas;
    }

    public override List<string> ObterChecklistObrigatorio()
    {
        List<string> checklist = base.ObterChecklistObrigatorio();
        checklist.Add("Tacógrafo");
        checklist.Add("Sistema de Freios a Ar");
        checklist.Add("Trava e Lona da Caçamba");
        return checklist;
    }
}

