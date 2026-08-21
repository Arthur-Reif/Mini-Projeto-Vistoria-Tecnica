namespace Mini_Projeto_Vistoria_Tecnica.Modelos;

public class Moto : Veiculo
{
    public double Cilindrada { get; set; }
    public Moto(string marca, string modelo, int ano, double km, double cilindrada) : base(marca, modelo, ano, km)
    {
        this.Cilindrada = cilindrada;
    }
    public override List<string> ObterChecklistObrigatorio()
    {
        List<string> checklist = base.ObterChecklistObrigatorio();
        checklist.Add("Kit Transmissão/Corrente");
        checklist.Add("Manetes de Freio/Embreagem");
        checklist.Add("Pezinho Lateral");
        return checklist;
    }
}