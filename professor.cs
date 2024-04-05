// ./professor.cs

public class professor
{
    private string cpf { get; set; }
    private string nome;

    // construtor que determina o nome a partir do cpf
    public professor(string cpf)
    {
        // Implementar a lógica de construção do objeto
        this.cpf = cpf;
        if (cpf == "888")
        {
            this.nome = "Pedro de Lara";
        }
        else if (cpf == "999")
        {
            this.cpf = cpf;
            this.nome = "Araci de Almeida";
        }
    }

    // construtor que recebe novo cpf e novo nome
    public professor(string cpf, string nome)
    {
        this.cpf = cpf;
        this.nome = nome;
    }

    //Atribui string ao nome
    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getNome()
    {
        return this.nome;
    }
}