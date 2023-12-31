using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Entities;
using ToDoApp.Core.DTO;
using ToDoApp.Core.Repositories;
using ToDoApp.Core.Services;

namespace TodoApp.Core.Services
{
    internal sealed class QuestService : IQuestService
    {
        private readonly IRepository<QuestDto> _repository;
        public QuestService(IRepository<QuestDto> repository)
        {
            _repository = repository;
        }

        
        public QuestDto AddQuest (QuestDto quest)
        {
            var id = GetLastID();
            quest.Id = id+1;
            _quests.Add(quest);
            return quest;
        }

        public QuestDto UpdateQuest(QuestDto quest)
        {
            return quest;
        }
        
        public void DeleteQuest (int id)
        {
            var quest = GetQuestById(id);
            if (quest != null)
            {
                return false;
            }
            _quests.Remove(quest);
            return true;
        }

        public QuestDto? GetQuestById(int id)
        {
            foreach (var quest in _quests)
            {
                if (quest.Id == id)
                {
                    return quest;
                }
            }
            return null;
        }
        public IReadOnlyList<QuestDto> GetAllQuests()
        {
            return _quests;
        }
    }
}
