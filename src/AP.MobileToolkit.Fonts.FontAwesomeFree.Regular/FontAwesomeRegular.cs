﻿using System.Runtime.CompilerServices;
using Xamarin.Forms;

[assembly: InternalsVisibleTo("AP.MobileToolkit.Fonts.Tests")]
[assembly: ExportFont(AP.MobileToolkit.Fonts.FontAwesomeRegular.FontName)]
namespace AP.MobileToolkit.Fonts
{
    public static class FontAwesomeRegular
    {
        internal const string FontName = "fa-regular-400.ttf";

        public const string Prefix = "far";

        public const string Version = "5.12.0";

        public static readonly IFont Font = new EmbeddedWebFont(FontName, Prefix, "fontawesome.min.css", typeof(FontAwesomeRegular));
    }
}
