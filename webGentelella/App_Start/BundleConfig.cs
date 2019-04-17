using System.Web;
using System.Web.Optimization;

namespace webGentelella
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //ace js
            //head
            bundles.Add(new ScriptBundle("~/bundles/acehead").Include(
                "~/Scripts/AceAdmin/js/ace-extra.min.js"
                //, "~/Scripts/AceAdmin/js/"
                ));
            //body
            bundles.Add(new ScriptBundle("~/bundles/acebody").Include(
                "~/Scripts/AceAdmin/js/jquery-2.1.4.min.js"
                , "~/Scripts/AceAdmin/js/bootstrap.min.js"
                , "~/Scripts/AceAdmin/js/jquery-ui.custom.min.js"
                , "~/Scripts/AceAdmin/js/jquery.ui.touch-punch.min.js"
                , "~/Scripts/AceAdmin/js/jquery.easypiechart.min.js"
                , "~/Scripts/AceAdmin/js/jquery.sparkline.index.min.js"
                , "~/Scripts/AceAdmin/js/jquery.flot.min.js"
                , "~/Scripts/AceAdmin/js/assets/js/jquery.flot.pie.min.js"
                , "~/Scripts/AceAdmin/js/jquery.flot.resize.min.js"
                , "~/Scripts/AceAdmin/js/ace-elements.min.js"
                , "~/Scripts/AceAdmin/js/ace.min.js"
                //, "~/Scripts/AceAdmin/js/"
                ));


            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //ace css
            bundles.Add(new StyleBundle("~/Content/ace").Include(
                  "~/Content/AceAdmin/css/bootstrap.min.css"
                , "~/Content/AceAdmin/font-awesome/4.5.0/css/font-awesome.min.css"
                , "~/Content/AceAdmin/css/fonts.googleapis.com.css"
                , "~/Content/AceAdmin/css/ace.min.css"
                , "~/Content/AceAdmin/css/ace-skins.min.css"
                , "~/Content/AceAdmin/css/ace-rtl.min.css"
                //, "~/Content/AceAdmin/css/"
                ));

            //BundleTable.EnableOptimizations = true;
        }
    }
}
