using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon
{
    
        public interface IReminder
        {
            void SetReminder(DateTime reminderTime, string message);
            event Action<string> OnReminderTriggered;

        }
    }
