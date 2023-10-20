using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskpractice20._10
{
    internal class Notebook : INotebook
    {
        public void GetById(int id)
        {
            Console.WriteLine("Notebook");
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
