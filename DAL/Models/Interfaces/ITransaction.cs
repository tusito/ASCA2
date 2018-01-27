using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.Interfaces
{
    public interface ITransaction
    {
        bool IsCompleted { get; set; }
        void Execute();
    }
}
