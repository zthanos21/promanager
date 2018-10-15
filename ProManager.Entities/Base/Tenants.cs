namespace ProManager.Entities.Base
{
    public class Tenants : BaseModel
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
