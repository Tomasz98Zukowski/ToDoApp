using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Entities;
using ToDoApp.Core.DTO;
using ToDoApp.Core.Mappings;
using ToDoApp.Core.Repositories;
using ToDoApp.Core.Services;

namespace TodoApp.Core.Services
{
    internal sealed class QuestService : IQuestService
    {
        private readonly IRepository<Quest> _repository;
        public QuestService(IRepository<Quest> repository)
        {
            _repository = repository;
        }

        
        public QuestDto AddQuest (QuestDto dto)
        {
            var quest = Quest.Create(dto.Title, dto.Description);
            _repository.Add(quest);
            return quest.AsDto();
        }

        public void UpdateQuest(QuestDto quest)
        {
         
        }
        
        public void DeleteQuest (int id)
        {
            
        }

        public QuestDto? GetQuestById(int id)
        {
            
        }
        public IReadOnlyList<QuestDto> GetAllQuests()
        {
            return _quests;
        }
    }
}
