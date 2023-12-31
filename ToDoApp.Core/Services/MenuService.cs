using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Entities;
using ToDoApp.Core.DTO;
using ToDoApp.Core.Mappings;
using ToDoApp.Core.Services;

namespace TodoApp.Core.Services
{
    public class MenuService : IMenuService
    {
        public readonly IEnumerable<Menu> _menus;
        public MenuService(IEnumerable<Menu> menus)
        {
            _menus = menus;
        }
        public IEnumerable<MenuDto> GetMenus()
        {
            var menuList = new List<MenuDto>();
            foreach (var menu in _menus)
            {
                menuList.Add(menu.AsDto());
            }
            return menuList;
        }

        public MenuDto? GetMenuById(int  id)
        {
            foreach (var menu in _menus)
            {
                if(menu.Id == id)
                {
                    return menu.AsDto();
                }
            }
            return null;
        }
    }
}
