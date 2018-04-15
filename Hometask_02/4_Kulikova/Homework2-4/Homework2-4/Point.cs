using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_4
{
    public class Point
    {
        /// <summary>
        /// координата Х
        /// </summary>
        private int _x;

        /// <summary>
        /// координата У
        /// </summary>
        private int _y;

        /// <summary>
        /// имя объекта
        /// </summary>
        private string _name;

        /// <summary>
        /// св-во возвращает координату Х
        /// </summary>
        public int X { get { return _x; } }

        /// <summary>
        /// св-во возвращает координату У
        /// </summary>
        public int Y { get { return _y; } }

        /// <summary>
        /// св-во возвращает имя объекта
        /// </summary>
        public string Name { get { return _name; } }
        
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="x">координата Х</param>
        /// <param name="y">координата У</param>
        /// <param name="name">имя</param>
        public Point(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }
    }
}
