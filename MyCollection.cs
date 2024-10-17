using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MyCollection<T>
    {
        public List<T> MainList;

        public MyCollection()
        {
            MainList = new List<T>();
        }

        public void AddItem(T list)
        {
            MainList.Add(list);
        }

        public T GetItem(int index)
        {
            return MainList[index];
        }
    }
}
