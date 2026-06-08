namespace GameScore;

// {
//
//     public class ScoreList
//     {
//         private int[] _scores;
//         private int _index;
//
//         public ScoreList()
//         {
//             _scores = new int[3];
//             _index = 0;
//         }
//
//         public void Add(int score)
//         {
//             _scores[_index] = score;
//             _index++;
//         }
//     }
// }

class Program
{
    static void Main()
    {
        var scores = new GenericList<int>();
        scores.Add(10);
        scores.Add(25);
        scores.Add(50);
        scores.Add(99);
        scores.Add(7);
        Console.WriteLine(scores.GetSummary());
    }
    
}