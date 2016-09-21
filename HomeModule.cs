namespace NancyFx
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => "Hello World");
            Get("/Tara", _ => Response.AsJson(new{Name="Hello Tara"}));
            Get("/Paul", _ => Response.AsXml(new{Name="Hello Paul"}));

            Get("/Xavier", _ => Response.AsXml(new { Name = "Sideshow Bob" }));

            Get("/Ayla", _ => "Hello Ayla");

            Get("/JSON", _ => {
                var test = new{Name="Paul LOgan", Age=40};
                return Response.AsJson(test);
            });

            Get("/RawJson", _ => {
                var xmlTest = new{Name="Paul LOgan", Age=40};
                return xmlTest;
            });
        }
    }
}
