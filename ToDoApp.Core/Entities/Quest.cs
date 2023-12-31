using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.Entities;
using ToDoApp.Core.Exceptions;

namespace TodoApp.Core.Entities
{
    public class Quest : BaseEntity
    {       
        
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
            return new Quest (0, title, description, QuestStatus.New, DateTime.UtcNow,null);   
        }

        public void ChangeTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new CustomException("Title cannot be empty");
            }

            if (title.Length < 2)
            {
                throw new CustomException("Title should contain at least 2 characters");
            }

            Title = title;
            Modified = DateTime.UtcNow;
        }

        public void ChangeDescription(string description)
        {
            Description = description;
            Modified = DateTime.UtcNow;
        }

        public void ChangeStatus(string status)
        {
            var parsed = Enum.TryParse<QuestStatus>(status, out var statusParsed);

            if (!parsed)
            {
                throw new CustomException($"There is no Quest status {status}");
            }

            if (!Enum.IsDefined(statusParsed))
            {
                throw new CustomException($"There is no Quest status {status}");
            }

            Status = statusParsed;
            Modified = DateTime.UtcNow;
        }


        public override string ToString()
        {
            return $"Title: {Title} Description:{Description} Status:{Status} ";
        }
    }
}
