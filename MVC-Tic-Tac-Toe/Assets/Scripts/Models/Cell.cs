

using System;

namespace Models
{
    public class Cell
    {
        private char symbol;
        public event Action<char> IconChanged;
        
        
        public char Symbol
        {
            get => symbol;
            set
            {
                symbol = value;
                IconChanged?.Invoke(symbol);
            }
        }
    }
}
