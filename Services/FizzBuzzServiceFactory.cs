namespace FizzBuzzApi.Services
{
    public class FizzBuzzServiceFactory : IFizzBuzzServiceFactory
    {
        public IFizzBuzzService Create()
        {
            return new FizzBuzzService();
        }
    }
}
