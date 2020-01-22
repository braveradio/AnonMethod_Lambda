using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonMethod_Lambda
{
    class Lesson
    {
        public string Name { get; set; }
        public DateTime Begin { get; private set; }
        public event EventHandler<DateTime> Started;
        public Lesson(string name)
        {
            // check input arguments
            Name = name;
        }
        public void Start()
        {
            Begin = DateTime.Now;
            Started?.Invoke(this, Begin);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
