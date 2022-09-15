namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(int id, string nome, string sobrenome)
    {
        Id = id;
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}