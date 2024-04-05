// ./carro.cas

public class carro
{
    public string ano { get; set; }

    public string marca { get; set; }
    public string modelo { get; set; }
    public motor Motor { get; set; }

    // Construtor do carro

    public carro(motor M)
    {
        this.Motor = M;
    }
}