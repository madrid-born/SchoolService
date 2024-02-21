using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Pages.School.Advertize;

namespace SchoolService.Pages.School;

public partial class SchoolAdvertise : ContentPage
{
    public SchoolAdvertise()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoryTypes());
    }
    
}