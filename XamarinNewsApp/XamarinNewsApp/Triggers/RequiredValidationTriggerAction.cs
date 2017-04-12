using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinNewsApp.Triggers
{
   public class RequiredValidationTriggerAction:TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            sender.BackgroundColor = string.IsNullOrEmpty(sender.Text) ? ConsoleColor.FromHex("#FFCDD2") : ConsoleColor.Default;
        }
    }
}
