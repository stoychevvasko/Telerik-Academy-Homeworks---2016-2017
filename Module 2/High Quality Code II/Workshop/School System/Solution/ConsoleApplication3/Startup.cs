namespace SchoolSystem
{
    using Core.Providers;

    public class Startup
    {
        public static void Main()
        {
            // TODO: abstract at leest 2 mor provider like thiso ne
            var reader = new Reader();

            var service = new BusinessLogicService();
            service.Execute(reader);
        }
    }
}
