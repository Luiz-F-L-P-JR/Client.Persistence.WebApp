
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Client.Persistence.Core.PublicArea.Model
{
    public sealed class PublicArea
    {
        [DisplayName("Identifier")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Client Identifier")]
        public int IdCliente { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? State { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? Neighborhood { get; set; }

        public PublicArea()
        {

        }

        public PublicArea(PublicArea publicArea)
        {
            Id = publicArea.Id;
            City = publicArea.City;
            State = publicArea.State;
            Address = publicArea.Address;
            IdCliente = publicArea.IdCliente;
            Neighborhood = publicArea.Neighborhood;
        }
    }
}
