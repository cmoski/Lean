using System;

namespace Python.Runtime
{
    public class PyObject
    {
        public PyObject()
        {
            throw new NotImplementedException("Python is not yet supported");
        }
    }

    public class Py
    {
        public static IDisposable GIL()
        {
            throw new NotImplementedException("Python is not yet supported");
        }
    }

    public class PythonException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:PythonException"/> class
        /// </summary>
        public PythonException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PythonException"/> class
        /// </summary>
        /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
        public PythonException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PythonException"/> class
        /// </summary>
        /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
        /// <param name="inner">The exception that is the cause of the current exception. </param>
        public PythonException(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}
