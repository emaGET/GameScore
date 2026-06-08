namespace GameScore;
        
        public class GenericList<T> //ScoreList
        {
            
            private T[] _values;
            private int _index;

            public GenericList()
            {
                _values = new T[3];
                _index = 0;
            }

            public void Add(T value)
            {
                
                if (_index >= _values.Length)
                {
                    var newValues = new T[_values.Length * 2];
                    Array.Copy(_values, newValues, _values.Length);
                    _values = newValues;
                }
                
                _values[_index] = value;
                _index++;
                
            }

            public string GetSummary()
            {
                var result = "";
                for (int i = 0; i < _index; i++)
                {
                    result += $"Player {i + 1} scored {_values[i]}\n";
                }
                return result;
            }
        }