
namespace Registration.Providers.Stubs
{
    using System;
    using Contracts;
    using Contracts.Providers;
    using Contracts.Registration;

    public class RegistrationProvider : IRegistrationProvider
    {
        public Result<Registration> Register(RegistrationRequest request)
        {
            throw new NotImplementedException();
        }

        public Result<Status> GetRegisteredStatus(string identityNumber)
        {
            throw new NotImplementedException();
        }

        public Result<Registration> Unsubscribe(string identityNumber)
        {
            throw new NotImplementedException();
        }

        public Result<Registration> UnRegister(string identityNumber)
        {
            throw new NotImplementedException();
        }
    }
}
