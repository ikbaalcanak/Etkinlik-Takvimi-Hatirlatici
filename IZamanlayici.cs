using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon
{
    public interface IZamanlayici
    {
        void Start();
        void Stop();
        void CheckScheduledEvents();
    }

}
