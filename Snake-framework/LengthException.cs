using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake
{
    public class LengthException : Exception
    {
        public override string Message
        {
            get
            {
                return "Введите минимум 3 символа";
            }
        }
    }
}

