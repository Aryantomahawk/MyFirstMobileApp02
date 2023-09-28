using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models
{

    //this is where I set the page values after clicking the first button on the first page
    public static class TitleLayouts
    {
        public static string PageTitle { get; } = "Layouts Menu";
        public static string InnerStackLayoutTitle { get; } = "Stack Layout";
        public static string VerticalStackTitle { get; } = "Vertical Stack";
        public static string HorizontalStackTitle { get; } = "Horizontal Stack";
        public static string AbsoluteLayoutTitle { get; } = "Absolute Layout";
    }
}