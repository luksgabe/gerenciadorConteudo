using System.Web;
using System.Web.Optimization;

namespace MVCProject
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/sortable","http://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js").Include(
                        "~/Scripts/jquery.sortable.js",
                        "~/Scripts/jquery.draganddrop.lib.js"));



            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/Controle").Include(
                        "~/Scripts/controle/jquery-slim.min.js",
                        "~/Scripts/controle/popper.min.js",
                        "~/Scripts/controle/popper.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Controle").Include(
                     "~/Content/Controle/bootstrap.min.css",
                     "~/Content/Controle/dashboard.css",
                     "~/Content/Controle/custom.css"
                     ));

            bundles.Add(new StyleBundle("~/Content/Sortable", "http://www.jqueryscript.net/css/jquerysctipttop.css").Include(
                "~/Content/Sortable/sortable.lib.css"
                ));

            bundles.UseCdn = true;
        }
    }
}
