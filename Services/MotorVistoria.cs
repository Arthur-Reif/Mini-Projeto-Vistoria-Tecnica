using Mini_Projeto_Vistoria_Tecnica.Modelos;

namespace Mini_Projeto_Vistoria_Tecnica.Services;

public class MotorVistoria
{
    public int ObterPontos(string status)
    {
        if (status == "Bom")
        {
            return 10;
        }
        else if (status == "Regular")
        {
            return 5;
        }
        else
        {
            return 0;
        }
    }
    public int CalcularPontuacao(Veiculo veiculo)
    {
        int pontos = 0;

        foreach (ItemVistoria item in veiculo.VistoriaRealizada)
        {
            pontos += ObterPontos(item.Status);
        }

        return pontos;
    }
}