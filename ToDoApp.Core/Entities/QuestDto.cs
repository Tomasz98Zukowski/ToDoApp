using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.Entities;

namespace TodoApp.Core.Entities
{
    public class Quest : BaseEntity
    {       
        public int Id { get;private set; }
        public string Title { get;private set; }
        public string Description { get;private set; }
        public QuestStatus Status { get;private set; }
        public DateTime Created { get;private set; }
        public DateTime? Modified { get;private set; }

        public Quest(int id, string title, string description, QuestStatus status, DateTime created, DateTime? modifed = null)
        {
            Id = id;
            ChangeTitle(title);
            ChangeDescritpion(description);
            ChangeStatus(status);
            Created = created;
            Modified = modifed;
        }

        public Quest(int id, string title, string description, QuestStatus status, DateTime created, DateTime? modifed = null )
        {
            Id = id;
            ChangeTitle(title);
            ChangeDescritpion(description);
            Status = status;
            Created = created;
            Modified = modifed;
        }

        public static Quest Create (string title, string description)
        {
            return new Quest (0, title, description, QuestStatus.New, DateTime.UtcNow);   
        }

        public override string ToString()
        {
            return $"Title: {Title} Description:{Description} Status:{Status} ";
        }
    }
}
