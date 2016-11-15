
namespace Registration.Testing
{
    using Contracts.Providers;
    using Providers.Stubs;
    using Providers;

    public class ProviderFactory
    {
        public static bool ShouldUseStubs = true;

        public static IRegistrationProvider CreateRegistrationProvider()
        {
            if (ShouldUseStubs)
            {
                return new RegistrationProviderStub();
            }

            return new RegistrationProvider();
        }
    }
}
