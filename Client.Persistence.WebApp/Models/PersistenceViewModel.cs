
namespace Client.Persistence.WebApp.Models
{
    public sealed class PersistenceViewModel
    {
        public Core.Client.Model.Client? Client { get; set; }
        public Core.PublicArea.Model.PublicArea? PublicArea { get; set; }

        public PersistenceViewModel()
        {
            Client.PublicAreas[0] = PublicArea;
        }
    }
}
