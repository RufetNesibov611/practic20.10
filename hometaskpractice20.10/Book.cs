using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskpractice20._10
{
    internal class Book : IBook
    {
        public string GetName()
        {
            throw new NotImplementedException();
        }

        public void ShowAll()
        {
            Console.WriteLine("Show books");
        }
    }
}
