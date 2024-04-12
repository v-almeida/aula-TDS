// ./caminhao.cs

public class caminhao : iVeiculo
{

    public int Eixos { get; set; }
    public string TipoCarga { get; set; }

    public Boolean CargaRisco { get; set; }

    public double PagarPedagio(double preco)
    {
        return preco * this.Eixos;
    }
}