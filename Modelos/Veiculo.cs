namespace Mini_Projeto_Vistoria_Tecnica.Modelos;

public abstract class Veiculo
{
    public string Marca {get ; set ;}
    public string Modelo {get ; set ;}
    public int Ano {get ; set ;}
    public double Quilometragem {get ; set ;}
    public List<ItemVistoria> VistoriaRealizada {get ; set ;}    
    
    public Veiculo(string marca, string modelo, int ano, double km)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Ano = ano;
        this.Quilometragem = km;
        this.VistoriaRealizada = new List<ItemVistoria>();
    }   
    public void AdicionarItemVistoriado(string nome, string status)
    {
        ItemVistoria item = new ItemVistoria(nome, status);
        this.VistoriaRealizada.Add(item);
    }
    public virtual List<string> ObterCheckistObrigatorio()
    {
        return new List<string>
        {
          "Nível de óleo do Motor",
          "Bateria e Sistema Elétrico",
          "Documentação Regularizada"  
        };
    }
}