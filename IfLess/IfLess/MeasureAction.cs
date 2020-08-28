using System;
using System.Collections.Generic;
using System.Text;

namespace IfLess
{
    public class MeasureAction
    {
        public Func<string, bool> CanAppply { get; set; }
        public Action Action { get; set; }

        public MeasureAction(Func<string, bool> canAppply, Action action)
        {
            CanAppply = canAppply;
            Action = action;
        }
    }
}
