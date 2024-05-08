namespace ApiAssessment.Service;

public class QueueService
{
    private static QueueService _instance;

    public static QueueService GetInstance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new QueueService();
            }

            return _instance;
        }
    }

    public bool PublishMessage(string message)
    {
        var queueUrl = "";

        if (string.IsNullOrEmpty(queueUrl))
        {
            throw new ArgumentException("queueUrl is empty");
        }

        return true;
    }
}