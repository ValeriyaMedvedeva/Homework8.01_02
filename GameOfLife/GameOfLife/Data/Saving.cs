using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Data
{
    public class Saving
    {
        public int Id { get; set; }
        public int typeGame { get; set; }
        public Object[,] gameField { get; set; }
    }
}
