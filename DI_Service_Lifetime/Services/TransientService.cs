namespace DI_Service_Lifetime.Services
{
    public class TransientService : ITransientInterface
    {
        public readonly string Id;

        public TransientService()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return Id;
        }
    }
}
