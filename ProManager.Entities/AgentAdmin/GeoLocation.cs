using ProManager.Entities.Base;

namespace ProManager.Entities.AgentAdmin
{
    public class GeoLocation : BaseTenantModel
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string MarkUri { get; set; }
    }
}
