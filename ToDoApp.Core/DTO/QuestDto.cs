using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Entities;

namespace ToDoApp.Core.DTO
{
    public class QuestDto : IBaseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public QuestStatus Status { get; set; }
        public string Status2 { get; set; } = QuestStatus.New.ToString();
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
