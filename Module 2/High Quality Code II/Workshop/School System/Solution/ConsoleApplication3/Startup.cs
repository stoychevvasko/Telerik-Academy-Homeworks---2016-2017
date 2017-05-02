namespace SchoolSystem
{
    using Core.Providers;

    public class Startup
    {
        public static void Main()
        {
            // TODO: abstract at least 2 more providers like this
            var reader = new Reader();
            var writer = new Writer();

            var service = new BusinessLogicService();
            service.Execute(reader, writer);
        }
    }
}
