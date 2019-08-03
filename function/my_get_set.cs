using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class my_get_set
    {
        private int id;
        private string name;
        private float salary;

        public int _ID
        {
            get { return id; }
            set { this.id = value; }
        }
        public string _NAME
        {
            get { return name; }
            set { this.name = value; }
        }
        public float _SALARY
        {
            get { return salary; }
            set { this.salary = value; }
        }

        private string my_print()
        {

            return _ID+"\n"+_NAME+"\n"+_SALARY;
        }
        public void print()
        {


          Console.WriteLine( my_print());
        }
    }
}
