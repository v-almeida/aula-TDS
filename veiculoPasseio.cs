// ./veiculoPasseio.cs

public class veiculoPasseio : iVeiculo
{
    public int Eixos { get; set; }
    public string Tecnologia { get; set; }

    public int Passageiros { get; set; }

    public double PagarPedagio(double preco)
    {

        return preco * 1;
    }
}