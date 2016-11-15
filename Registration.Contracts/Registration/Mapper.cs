
namespace Registration.Contracts.Registration
{
    public static class Mapper
    {
        public static RegistrationRequest MapRequest(this Registration original)
        {
            if (original == null) return null;

            return new RegistrationRequest
            {
                IdentityNumber = original.IdentityNumber
            };
        }
    }
}
