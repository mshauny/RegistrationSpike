
namespace Registration.Testing.Data.Builders
{
    using System;
    using Contracts.Registration;
    
    public class RegistrationBuilder : Contracts.Registration.Registration
    {
        public RegistrationBuilder(Guid? id = null)
        {
            this.Id = id ?? Guid.NewGuid();
        }

        public RegistrationBuilder JohnDoe()
        {

            return this;
        }

        public RegistrationBuilder JaneDoe()
        {

            return this;
        }


        public Contracts.Registration.Registration Build()
        {
            return this;
        }

        public RegistrationRequest BuildRequest()
        {
            return this.MapRequest();
        }
    }
}
