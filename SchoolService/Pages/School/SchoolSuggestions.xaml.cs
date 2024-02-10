using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Models;
using SchoolService.Temp;

namespace SchoolService.Pages.School;

public partial class SchoolSuggestions : TabbedPage
{
    public SchoolSuggestions()
    {
        InitializeComponent();
        LoadPages();
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

    private async Task LoadPages()
    {
        await Task.Delay(100);
        Children.Add(new SchoolAdvertise());
        await Task.Delay(100);
        Children.Add(new SchoolChat());
        await Task.Delay(100);
        Children.Add(new SchoolAdvertiseHistory());
        await Task.Delay(100);
        Children.Add(new SchoolSuggestions());
        await Task.Delay(100);
        Children.Add(new SchoolNews());
    }
}