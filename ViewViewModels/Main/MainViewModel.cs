using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main
{
    internal class MainViewModel : BaseViewModel
    {

        //public String Layouts { get; set; } = TitleMain.Layouts; 

        //Button Commands

       public ICommand OnLayoutsClicked { get; set; }

       public MainViewModel() {

            Title = TitleMain.MainTitle;
            StackLayoutTitle = TitleMain.StackLayoutTitle;

            //Set Commands

            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);

        }

        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
        }
    }
}
