namespace Mini_Projeto_Vistoria_Tecnica.Modelos;

public class ItemVistoria
{
    public string Nome { get; set; }
   public string Status { get; set; }
    
    public ItemVistoria(string nome, string status)
    {
        this.Nome = nome;
        this.Status = ValidarStatus(status);
    }

    public string ValidarStatus(string status)
    {
        do
        {
            if (status == "Bom" || status == "Regular" || status == "Ruim")
            {
                return status;
            }
            else
            {
                Console.WriteLine("Status inválido. Por favor, insira 'Bom', 'Regular' ou 'Ruim'.");
                Console.Write("Digite o status do item: ");
                status = Console.ReadLine();
            }
        }
        while (status != "Bom" && status != "Regular" && status != "Ruim");

        return status;
    }
}
