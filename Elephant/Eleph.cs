using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    class Eleph
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("My ears have " + EarSize + " centimeters", Name + " says...");
        }
    }
}
