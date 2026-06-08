namespace GameScore.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var list = new ScoreList();
        list.Add(10);
        list.Add(25);

        var summary = list.GetSummary();
        
        Assert.That(summary, Does.Contain("Player 1 scored 10"));
    }
}