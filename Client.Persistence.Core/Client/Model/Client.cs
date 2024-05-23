
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Client.Persistence.Core.Client.Model
{
    public sealed class Client
    {
        [DisplayName("Identifier")]
        public int Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo nome é obrigatório.")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Mínimo de 2 caracteres.")]
        public string? Name { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Campo e-mail é obrigatório.")]
        [MaxLength(100, ErrorMessage = "Máximo de 100 caracteres.")]
        [MinLength(10, ErrorMessage = "Mínimo de 10 caracteres.")]
        [EmailAddress(ErrorMessage = "Preencha com um email válido")]
        public string? Email { get; set; }

        [DisplayName("Logotipo")]
        public string? Logo { get; set; }

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
