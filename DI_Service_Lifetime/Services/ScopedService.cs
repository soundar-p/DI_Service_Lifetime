namespace DI_Service_Lifetime.Services
{
    public class ScopedService : IScopedInterface
    {
        public readonly string Id;

        public ScopedService()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
