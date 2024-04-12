// ./pedagio.cs

public class pedagio
{
    public string NomePraca { get; set; }

    public double PrecoPorEixo { get; set; }

    public Boolean CobrarPedagio(iVeiculo veiculo)
    {
        double ValorPago = veiculo.PagarPedagio(this.PrecoPorEixo);
        // [BISU] Linha para testes. Será apagado.
        Console.WriteLine("Preco cobrado: " + ValorPago);

        // Lógica: se entregou o valor, grava na base de dados
        return true;
        // se não entregou o valor, emite um erro.
    }
}