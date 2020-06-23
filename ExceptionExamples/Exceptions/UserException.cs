using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExamples.Exceptions { //.foldername
    public class UserException : Exception {//must inherrit from Exception

        public double NumberInError { get; set; } //property to collect number error

        public UserException() : base() { } //override default constructor

        public UserException(string message) : base(message) { } //constructor with message

        public UserException (string message, Exception innerException) 
            : base(message, innerException) { }//constructor with inner exception and message

    }
}
