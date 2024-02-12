using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Models;
using SchoolService.Temp;

namespace SchoolService.Pages.School.Advertize;

public partial class CategoryTypes : ContentPage
{
    private List<Ability> _abilities ;
    public CategoryTypes()
    {
        InitializeComponent();
        _abilities = RandomDatas.AbilityGenerator(10);
        ListView.ItemsSource = _abilities;
    }

    private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (ListView.ItemsSource != null)
        {
            DisplayAlert("Database", "Datashouldpush_to database", "ok");
        }
    }

    private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        ListView.ItemsSource = null;
    }
}