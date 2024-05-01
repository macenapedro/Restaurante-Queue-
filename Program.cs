//criando a fila vazia
Queue<Pedido> filaPedidos = new();

//adicionando pedidos
filaPedidos.Enqueue(new Pedido(101, 10.0));
filaPedidos.Enqueue(new Pedido(202, 20.0));
filaPedidos.Enqueue(new Pedido(303, 30.0));

//exibe o número de pedidos na fila
Console.WriteLine("\nNúmero de pedidos na fila : " + filaPedidos.Count);

//processar os pedidos da fila
while(filaPedidos.Count > 0)
{
    //retirar pedidos da fila
    Pedido proximoPedido = filaPedidos.Dequeue();

    Console.WriteLine($"Processando o pedido {proximoPedido.Numero}, valor {proximoPedido.Valor}");
}

//adicionando mais pedidos na fila
filaPedidos.Enqueue(new Pedido(404, 40.0));
filaPedidos.Enqueue(new Pedido(505, 50.0));
filaPedidos.Enqueue(new Pedido(606, 60.0));

//localizar pedido na fila
int numeroPedido = 505;
Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(x => x.Numero == numeroPedido);

if(pedidoLocalizado != null)
{
    Console.WriteLine($"\nPedido {pedidoLocalizado.Numero}, valor {pedidoLocalizado.Valor}");
} else
{
    Console.WriteLine("\nPedido não localizado");
}


Console.ReadKey();

class Pedido
{
    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }
    public int Numero { get; set; }
    public double Valor { get; set; }
}