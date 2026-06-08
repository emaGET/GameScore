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
        var list = new ScoreList();
        list.Add(10);
        list.Add(25);
        list.Add(50);
        list.Add(99);
        list.Add(7);
        Console.WriteLine(list.GetSummary());
    }
    
}