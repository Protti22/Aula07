Estoque baitaca = new Estoque();
Console.WriteLine("Informe o modo de produto para adicionar o estoque");
baitaca.produto = Console.ReadLine();
Console.WriteLine("Informe a quantidade de produtos");
int quantidade = Convert.ToInt32(Console.ReadLine());
baitaca.AdicionarEstoque(quantidade);
Console.WriteLine("Informe o valor do produto");
baitaca.preco = Convert.ToDouble(Console.ReadLine());

baitaca.ExibeInformacao();