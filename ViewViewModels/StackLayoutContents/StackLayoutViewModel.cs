using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.StackLayoutContents
{
    public class StackLayoutViewModel : BaseViewModel
    {


        //Titles
        public string Title { get; set; } = TitleLayouts.PageTitle;
        public string InnerStackLayoutTitle { get; set; } = TitleLayouts.InnerStackLayoutTitle;
        public string VerticalStackTitle { get; set; } = TitleLayouts.InnerStackLayoutTitle;
        public string HorizontalStackTitle { get; set; } = TitleLayouts.InnerStackLayoutTitle;
        public string AbsoluteLayoutTitle { get; set; } = TitleLayouts.InnerStackLayoutTitle;

        //Constructor 
        public StackLayoutViewModel()
        {

            Title = TitleLayouts.PageTitle;
            InnerStackLayoutTitle = TitleLayouts.InnerStackLayoutTitle;
            VerticalStackTitle = TitleLayouts.VerticalStackTitle;
            HorizontalStackTitle = TitleLayouts.HorizontalStackTitle;
            AbsoluteLayoutTitle = TitleLayouts.AbsoluteLayoutTitle;




        }
    }
}