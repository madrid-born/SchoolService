using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Models;
using SchoolService.Temp;

namespace SchoolService.Pages.School;

public partial class SchoolHome : ContentPage
{
    public SchoolHome()
    {
        InitializeComponent();
        ListSuggestions.ItemsSource = RandomDatas.SuggestionGenerator(10);
    }
    
    private async void ListSuggestions_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (ListSuggestions.SelectedItem != null)
        {
            await Navigation.PushAsync(new SuggestionPage((Suggestion)ListSuggestions.SelectedItem));
        }
    }

    private void ListSuggestions_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        ListSuggestions.SelectedItem = null;
    }
}