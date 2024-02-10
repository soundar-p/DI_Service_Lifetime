namespace DI_Service_Lifetime.Services
{
    public class SingletonService : ISingletonInterface
    {
        public readonly string Id;

        public SingletonService()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return Id;
        }
    }
}
