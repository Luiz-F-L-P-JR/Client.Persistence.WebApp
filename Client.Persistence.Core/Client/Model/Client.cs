
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Client.Persistence.Core.Client.Model
{
    public sealed class Client
    {
        [DisplayName("Identifier")]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Logo { get; set; }

        [Required]
        public IList<PublicArea.Model.PublicArea>? PublicAreas { get; set; }

        public Client()
        {
            PublicAreas = new List<PublicArea.Model.PublicArea>();
        }

        public Client(Client client)
        {
            Id = client.Id;
            Name = client.Name;
            Email = client.Email;
            Logo = client.Logo;
            PublicAreas = client.PublicAreas;
        }
    }
}
