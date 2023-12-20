using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgram
{
    public class Quest
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        private QuestStatus Status { get; set; }
        private DateTime Created { get; set; }
        private DateTime? Modified { get; set; }

        public override string ToString()
        {
            return $"Title: {Title} Description:{Description} Status:{Status} ";
        }
    }
}
