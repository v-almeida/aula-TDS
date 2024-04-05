// .ave.cs

public class ave : animal
{


    public string tipo_plumagem;

    override
    public string somEmitido()
    {
        string retorno = "";
        retorno = base.somEmitido() + "gorjeia";
        return retorno;
    }
}