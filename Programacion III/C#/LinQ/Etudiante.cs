using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Etudiante
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public int ID { get; set; }
        public int Year { get; set; }
        public List<int> ExamScores { get; set; }
    }
}
