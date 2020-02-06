using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenhorn_Innkeeper_
{
    class Room
    {
        public string name;
        public bool taken = false;
        public Label label = new Label(); // ulatwienie zycia zeby nie przejmowac sie zmiana labelu manualnie
        public int nightsRemains;

        public Room(string name, bool taken, int nightRemains)
        {
            this.name = name;
            this.taken = taken;
            this.nightsRemains = nightRemains;
        }

        public void SetLabel(Label label)
        {
            this.label = label;
        }
    }
}
