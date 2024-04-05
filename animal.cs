// ./animal.cs
using System.Security.Cryptography.X509Certificates;

public class animal
{
    public string especie;

    public string porte;

    public string classe;

    public string alimentacao;

    public string patas;

    public int peso;

    public virtual string somEmitido()
    {
        return "ZZZZZZZZ";
    }


}