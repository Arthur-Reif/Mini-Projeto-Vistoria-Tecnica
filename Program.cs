using Mini_Projeto_Vistoria_Tecnica.Modelos;

///Veiculo veiculo = new Veiculo("Fiat", "Uno", 2015, 75000);

///Console.WriteLine($"Marca: {veiculo.Marca}");
///Console.WriteLine($"Modelo: {veiculo.Modelo}");
///Console.WriteLine($"Ano: {veiculo.Ano}");
///Console.WriteLine($"Quilometragem: {veiculo.Quilometragem}");

///Estava usando acima porque tive problema com a classe veiculo, mas eu tava usando o namespace errado...
///Deixei a Classe Veiculo como abstrata, já que ela não vai ser usada diretamente
///O que for criado que for ligado aos requisitos pode ir colocando informações embaixo ali.
///Se quiser pode criar classes de teste e deixa comentado depois
///Vou tentar ver os materias complementares e os slides pra ajudar no intervalo do trabalho
///Vou mexer no cód geralmente a noite e de manhã.
/// 
/// 
///RF01 - Modelo do Item de vistoria(ItemVistoria) - teoricamente feito
///RF02 - Classe Base Veiculo - Classe pai criada com atributos e métodos comuns a todos os tipos de veículos.
///RF03 - Herança e Checklists Especificos - Feito de acordo com o que pede no arquivo de requisitos.
///RF04 - Tabela de Pontuação por Item - (Já tem o checklist, mas precisa percorrer a lista de itens vistoriados e calcular a pontuação de acordo.)
///RF05 - Cálculo do Percentual de Aprovação - (Cuidar com o calculo da porcentagem)
///RF06 - Classificação do Estado do Veiculo - ()
///RF07 - Relatório de Pendencias e Apontamentos - (Ruim reprovado - regular bom mas precisa arrumar e bom aprovado sem apontamentos)
///RF08 - Recomendação de Serviços da Oficina - (O que tiver ruim ou regular precisa de recomendação de serviço.)
///RF09 - Varredura de Listas com Laços Tradicionais - (Precisa ser feito para o checklist na pontuação e depois para percorrer a lista de vistoria))
///RF10 - Exibição no Terminal(Console Application) - (Exebir a lista de vistoria com o contador de quantidade de vistorias.)
///RF11 - Menu Principal e Navegação(Consle.ReadLine) - Criado o esqueleto do menu principal. 


Console.WriteLine("Olá bem vindo a nossa vistoria tecnica");

bool continuar = true;

while (continuar)
{
    Console.WriteLine("1 - Para realizar uma nova vistoria");
    Console.WriteLine("2 - Para exibir todas as vistorias realizadas");
    Console.WriteLine("3 - Para sair");

    int escolha = ObtemUmNumero("Escolha: ");

    if (escolha == 1)
    {
        RealizarNovaVistoria();
    }
    else if (escolha == 2)
    {
        //ExibirVistorias()
    }
    else if (escolha == 3)
    {
        continuar = false;
    }
    else
    {
        Console.WriteLine("Numero invalido digite novamente");
    }

}

static int ObtemUmNumero(string mensagem)
{
    Console.WriteLine(mensagem);

    bool ehNumero = int.TryParse(Console.ReadLine(), out int num);
    while (!ehNumero)
    {
        Console.WriteLine("Numero invalido digite novamente");
        ehNumero = int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

void RealizarNovaVistoria()
{
    Console.WriteLine("Vistoria de Veículo: diga o tipo de veículo que deseja vistoriar:");
    Console.WriteLine("1 - Carro");
    Console.WriteLine("2 - Moto");
    Console.WriteLine("3 - Caminhão");
    Console.Write("Tipo de veículo: ");
    string tipo = Console.ReadLine();

    Console.WriteLine("Marca: ");
    string marca = Console.ReadLine();

    Console.WriteLine("Modelo: ");
    string modelo = Console.ReadLine();

    Console.WriteLine("Ano: ");
    int ano = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Quilometragem (km): ");
    double quilometragem = double.Parse(Console.ReadLine());

    Veiculo veiculo;

    if (tipo == "1")
    {
        Console.WriteLine("Quantidade de portas: ");
        int quantidadePortas = int.Parse(Console.ReadLine());
        veiculo = new Carro(marca, modelo, ano, quilometragem, quantidadePortas);
    }
    else if (tipo == "2")
    {
        Console.WriteLine("Cilindradas: ");
        int cilindradas = int.Parse(Console.ReadLine());
        veiculo = new Moto(marca, modelo, ano, quilometragem, cilindradas);
    }
    else
    {
        Console.WriteLine("Quantidade de eixos: ");
        int quantidadeEixos = int.Parse(Console.ReadLine());
        Console.WriteLine("Capacidade de carga (toneladas): ");
        double CapacidadeCargaToneladas = double.Parse(Console.ReadLine());
        veiculo = new Caminhao(marca, modelo, ano, quilometragem, quantidadeEixos, CapacidadeCargaToneladas);
    }
}

///Criar a parte do checklist
 

///Criar a parte de pontuação

 
///Criar a parte de exibição
 

///Criar parte de recomendação de serviços
 

///Revisar e criar condições a prova de seres humanos com baixo QI ou velhinhos.