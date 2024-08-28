using Business.Enums;

namespace Business.Entities;

public class Pedido : BaseEntity
{
    private Pedido(StatusPedido statusPedido, DateTime dataCriacao, decimal total, string enderecoEntrega)
    {
        StatusPedido = statusPedido;
        DataCriacao = dataCriacao;
        Total = total;
        EnderecoEntrega = enderecoEntrega;
    }

    public StatusPedido StatusPedido { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public decimal Total { get; private set; }
    public string EnderecoEntrega { get; private set; }
}