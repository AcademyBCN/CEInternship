using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class ExampleResponseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Terrain { get; set; } = string.Empty;
    }
}
