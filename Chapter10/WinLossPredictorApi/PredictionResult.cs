namespace WinLossPredictorApi;

public class PredictionResult 
{
    public string PredictedLabel {get; set;}
    public float[] Score {get; set;}
}