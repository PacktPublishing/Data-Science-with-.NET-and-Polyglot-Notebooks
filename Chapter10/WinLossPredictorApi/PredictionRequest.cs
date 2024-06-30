namespace WinLossPredictorApi;

public class PredictionRequest
{
    public float OurPosition { get; set; }
    public float OpponentPosition { get; set; }
    public bool IsHome { get; set; }
    public string Label {get; set;}
}