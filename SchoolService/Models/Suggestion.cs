using System.Net.Mime;

namespace SchoolService.Models;

public class Suggestion
{
    public Worker Worker { get; set; }
    public string Title { get; set; }
    public string Detail { get; set; }
    public string IdeaImplement { get; set; }
    // public int SuggestionId { get; set; }
    public Suggestion(string title, string detail, string ideaImplement)
    {
        Title = title;
        Detail = detail;
        IdeaImplement = ideaImplement;
    }

    public void AddWorker(Worker worker)
    {
        Worker = worker;
    }
}