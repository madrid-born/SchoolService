namespace SchoolService.Models;

public class WorkerSuggestion
{
    public Worker worker { get; set; }
    public string title { get; set; }
    public string detail { get; set; }
    public string idea_implement { get; set; }
    public int suggestion_number { get; set; }
    public int suggestion_id { get; set; }
    /*public WorkerSuggestion(int id)
    {
        worker = WorkerRepository.GetWorker_by_id(id);
    }*/
}