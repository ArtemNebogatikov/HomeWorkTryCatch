using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEvent
{
    class NumberRead
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;
        public int Read() 
        {
            Console.WriteLine("Необходимо ввести значение: 1 для сортировки А-Я, 2 для сортировки Я-А");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new MyExceptions();

            NumberEntered(number);
            return number;
        }

        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
}
