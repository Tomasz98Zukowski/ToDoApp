using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Entities;
using ToDoApp.Core.DTO;

namespace ToDoApp.Core.Services
{
    public interface IQuestService : IService<DTO.QuestDto>
    {
        DTO.QuestDto AddQuest(TodoApp.Core.Entities.QuestDto quest);


        DTO.QuestDto UpdateQuest(TodoApp.Core.Entities.QuestDto quest);

        void DeleteQuest(int id);


        DTO.QuestDto? GetQuestById(int id);

        IReadOnlyList<DTO.QuestDto> GetAllQuests();
        
    }
}
