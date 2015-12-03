using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UserInput;

namespace Calculator
{
    class Program
    {
        //Дефиниране на библиотеки
      public  UserInput.UInput uInput = new UInput();
        public About.Me about = new About.Me();

        static void Main(string[] args)
        {
           Program _program = new Program();

            //Форматиране
            Console.Title = _program.about.shortName + ", " + _program.about.version;

            //Стартиране на програмата
            _program.uInput.sayHello();
            _program.uInput.getUserCommands();
            
        }
    }
}
