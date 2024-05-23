namespace Client.Persistence.WebApp.Models
{
    public class ClientViewModel
    {
        public Core.Client.Model.Client? Client { get; set; }
        public IEnumerable<Core.PublicArea.Model.PublicArea>? PublicAreas { get; set; }
    }
}
