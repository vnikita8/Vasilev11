﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasilev11
{
    internal class BankTransaction
    {
        public readonly double TransferMoney;
        public readonly DateTime DateTimeInfo;

        public BankTransaction(double transferSumm)
        {
            TransferMoney = transferSumm;
        }
    }
}
