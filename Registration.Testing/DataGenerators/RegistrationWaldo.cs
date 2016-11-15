
namespace Registration.Testing.DataGenerators
{
    using Data.Builders;
    
    public class RegistrationWaldo
    {
        public static void RegisterJohnDoe()
        {
            var provider = ProviderFactory.CreateRegistrationProvider();
            var request = new RegistrationBuilder().JaneDoe().BuildRequest();
        }
    }
}
