using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public List<Tuple<string, bool>> PossibleAnwser{ get; set; }

    }
}
