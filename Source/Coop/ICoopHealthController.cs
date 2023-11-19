﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayInTarkov.Coop
{
    internal interface ICoopHealthController
    {
        public void ReceiveSetEncumbered(bool encumbered);
        public void ReceiveFatigue();
    }
}
