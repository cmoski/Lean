﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Python.Runtime
{
    public class PyObject : List<PyObject>, IDisposable
    {
        public IntPtr Handle { get; set; }

        public PyObject()
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public T As<T>()
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public dynamic GetAttr(string attrName)
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public dynamic HasAttr(string attrName)
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public dynamic InvokeMethod(string methodName)
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public dynamic GetPythonType()
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public dynamic AsManagedObject(dynamic type)
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public dynamic Repr()
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public static implicit operator PyObject(PyList v)
        {
            throw new NotImplementedException();
        }
    }

    public class Py
    {
        public static IDisposable GIL()
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public static object Import(string import)
        {
            throw new NotImplementedException("Python is not yet supported");
        }
    }

    public class PythonEngine
    {
        public static PyObject ModuleFromString(params string[] arguments)
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public static void Exec(string code, object p, object handle)
        {
            throw new NotImplementedException();
        }
    }

    public class PyList : IDisposable
    {
        public PyList(dynamic args)
        {
            throw new NotImplementedException("Python is not yet supported");
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Length()
        {
            throw new NotImplementedException();
        }

        public static bool IsListType(PyObject pyObject)
        {
            throw new NotImplementedException();
        }
    }

    public class PyDict : IDisposable
    {
        public object Handle { get; set; }

        public PyDict(dynamic args = null)
        {

        }

        public List<PyObject> Items()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SetItem(string s, dynamic obj)
        {
            throw new NotImplementedException();
        }

        public dynamic GetItem(string item)
        {
            throw new NotImplementedException();
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

    public static class PythonExt
    {
        public static dynamic ToPython(this Type T)
        {
            throw new NotImplementedException();
        }

        public static dynamic DefineDynamicAssembly(this AppDomain domain, AssemblyName name, AssemblyBuilderAccess an)
        {
            throw new NotImplementedException();
        }
    }

    public class PyString
    {
        public static bool IsStringType(PyObject item)
        {
            throw new NotImplementedException();
        }
    }

    public enum AssemblyBuilderAccess
    {
        Run = 1
    }
}