using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comicshdo.Models
{
    public class Bootstrap
    {
        public const string BundleBase = "~/lib/bootstrap/dist/css/";

        public class Theme
        {
            public const string bootstrapDark = "bootstrapDark";
            public const string bootstrapLight = "bootstrapLight";
        }

        public static HashSet<string> Themes = new HashSet<string>
    {

        Theme.bootstrapDark,
        Theme.bootstrapLight
    };

        public static string Bundle(string themename)
        {
            return BundleBase + themename;
        }
    }
}
