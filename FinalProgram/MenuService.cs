using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgram
{
    public class MenuService
    {
        public readonly IEnumerable<Menu> _menus;
        public MenuService(IEnumerable<Menu> menus)
        {
            _menus = menus;
        }
        public IEnumerable<Menu>GetMenus() => _menus;

        public Menu? GetMenuById(int  id)
        {
            foreach (Menu menu in _menus)
            {
                if(menu.Id == id)
                {
                    return menu;
                }
            }
            return null;
        }
    }
}
