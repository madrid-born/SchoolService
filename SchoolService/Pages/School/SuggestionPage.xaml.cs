using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Models;
using SchoolService.Temp;

namespace SchoolService.Pages.School;

public partial class SuggestionPage : ContentPage
{
    public Suggestion Suggestion;
    public SuggestionPage(Suggestion suggestion)
    {
        InitializeComponent();
        Suggestion _Suggestion= suggestion;
        ImagePath.Source = ImageSource.FromFile(_Suggestion.Worker.ImagePath);
        Age.Text = _Suggestion.Worker.Age.ToString();
        Exprience.Text = _Suggestion.IdeaImplement;
        /*Field.Text = suggestion.worker.Abilities.ToString();*/
        Title.Text = _Suggestion.Title;
        Idea.Text = _Suggestion.Detail;
    }

    private async void SwipeGestureRecognizer_OnSwiped(object sender, SwipedEventArgs e)
    {
        if (e.Direction == SwipeDirection.Right)
        {
            try
            {
                await Navigation.PopAsync();
                /*Navigation.RemovePage(Navigation.NavigationStack[0]);*/
            }
            catch (Exception exception)
            {
                await DisplayAlert("Error", exception.ToString(), "Ok");
                throw;
            }
        }
    }
}