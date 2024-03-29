using System.Text.Json.Serialization;

namespace Library;
public class Customer : IHasID
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("tables")]
    public List<Table> Tables { get; set; }

    [JsonPropertyName("orderId")]
    public List<int> OrderIds { get; set; }

    public Customer(int id, List<Table> tables)
    {
        Id = id;
        Tables = tables;
        OrderIds = new();
    }
}




