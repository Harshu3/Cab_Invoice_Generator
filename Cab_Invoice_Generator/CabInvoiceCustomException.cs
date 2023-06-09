﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class CabInvoiceCustomException : Exception
    {
        public ExceptionTypes exceptionTypes;

        public enum ExceptionTypes
        {
            INVALID_DISTANCE,
            INVALID_TIME,
            EMPTY_RIDE 
        }

        public CabInvoiceCustomException(string message, ExceptionTypes exceptionTypes) : base(message)
        {

            this.exceptionTypes = exceptionTypes;
        }
    }
}
