namespace RabbitMQMassTransitExampleAPI.DTOs
{
    public sealed class OrderDto
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
