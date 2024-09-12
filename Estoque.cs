class Estoque
{
    public string produto;
    public int quantidade;
    public double preco;

    public void AdicionarEstoque(int valor)
    {
        quantidade += valor;
    }

    public void RemoverDoEstoque(int quantidade)
    {
       this.quantidade -= quantidade;
    }

    public double RetornarValorTotalDoEstoque()
    {
        return quantidade * preco;
    }

    public void ExibeInformacao()
    {
        Console.WriteLine($"Nome do Produto {produto} ");
        Console.WriteLine($"Quantidade de Produtos {quantidade}");
        Console.WriteLine($"Valor do Produtor {preco}");

    }

}