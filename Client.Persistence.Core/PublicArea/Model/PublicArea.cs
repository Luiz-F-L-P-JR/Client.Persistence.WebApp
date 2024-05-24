
using Client.Persistence.Core.PublicArea.Model.Interface;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Client.Persistence.Core.PublicArea.Model
{
    public sealed class PublicArea : IPublicArea
    {
        [DisplayName("Identifier")]
        public int Id { get; set; }

        [DisplayName("Client Identifier")]
        public int IdCliente { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Campo cidade é obrigatório.")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres.")]
        public string? City { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "Campo estado é obrigatório.")]
        [MaxLength(30, ErrorMessage = "A estado deve conter apenas 30 digitos.")]
        [MinLength(5, ErrorMessage = "A estado deve conter apenas 5 digitos.")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Campo cidade é obrigatório.")]
        [MaxLength(120, ErrorMessage = "Máximo de 120 caracteres.")]
        [MinLength(15, ErrorMessage = "Mínimo de 15 caracteres.")]
        public string? Address { get; set; }

        [DisplayName("Bairro")]
        [Required(ErrorMessage = "Campo bairro é obrigatório.")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres.")]
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
