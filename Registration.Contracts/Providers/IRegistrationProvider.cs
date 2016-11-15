using Registration.Contracts.Registration;

namespace Registration.Contracts.Providers
{
    public interface IRegistrationProvider
    {
        Result<Registration.Registration> Register(RegistrationRequest request);

        Result<Status> GetRegisteredStatus(string identityNumber);

        Result<Registration.Registration> Unsubscribe(string identityNumber);

        Result<Registration.Registration> UnRegister(string identityNumber);
    }
}
