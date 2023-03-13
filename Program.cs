
using AtvOO13032023;

Cliente cliente1 = new Cliente()
{
    Id = 1,
    Nome = "Thiago",
    Telefone = "16997858585",
    NomePai = "Marcio",
    NomeMae = "Maria",
    Endereco = new Endereco()
    {
        Id = 2,
        Logradouro = "Nenhum",
        Bairro = "Centro",
        Numero = "258",
        Cep = "14855000"
    }
};

Console.WriteLine(cliente1);