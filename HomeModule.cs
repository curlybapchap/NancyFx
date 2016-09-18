namespace NancyFx
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => "Hello World");
            Get("/Tara", _ => "Hello Tara");
            Get("/Paul", _ => "Hello Paul");
            Get("/Xavier", _ => "Hello Xavier");
            Get("/Ayla", _ => "Hello Ayla");
        }
    }
}
