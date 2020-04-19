using System;
using System.Collections.Generic;

namespace PrototipoWebApi_1.Abstract
{
    public class OperationResult<T>
    {
        public OperationResult()
        {
            Messages = new List<string>();
        }

        public bool Success { get; set; }

        public T ResultObject { get; set; }
        public List<string> Messages { get; set; }
    }
}
