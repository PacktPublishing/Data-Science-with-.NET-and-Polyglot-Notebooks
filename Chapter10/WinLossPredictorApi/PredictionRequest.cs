namespace WinLossPredictorApi;

public class PredictionRequest
{
    public float OurPosition { get; set; }
    public float OpponentPosition { get; set; }
    public float OurGoalsLast3Games {get; set;}
    public float OpponentGoalsLast3Games {get; set;}
    public bool IsHome { get; set; }
    public string Label {get; set;}
}