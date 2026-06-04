namespace GameScore;
        
        public class ScoreList
        {
            
            private int[] _scores;
            private int _index;

            public ScoreList()
            {
                _scores = new int[3];
                _index = 0;
            }

            public void Add(int score)
            {
                
                if (_index >= _scores.Length)
                {
                    var newScores = new int[_scores.Length * 2];
                    Array.Copy(_scores, newScores, _scores.Length);
                    _scores = newScores;
                }
                
                _scores[_index] = score;
                _index++;
                
            }
            
        }