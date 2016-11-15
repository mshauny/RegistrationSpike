
namespace Registration.Testing
{
    using Contracts.Providers;
    using Providers.Stubs;
    
    public class ProviderFactory
    {
        public static IRegistrationProvider CreateRegistrationProvider()
        {
            return new RegistrationProvider();
        }
    }
}
