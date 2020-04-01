using System;
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

        public dynamic InvokeMethod(string methodName, dynamic[] dynamic = null)
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

        public dynamic GetIterator()
        {
            throw new NotImplementedException();
        }

        public dynamic Invoke()
        {
            throw new NotImplementedException();
        }

        public dynamic GetItem(PyObject pyKey)
        {
            throw new NotImplementedException();
        }

        public bool IsIterable()
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

        public static dynamic Import(string import)
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public static object kw(string v1, bool v2)
        {
            throw new NotImplementedException();
        }
    }

    public class PythonEngine
    {
        public static object Version { get; set; }

        public static PyObject ModuleFromString(params string[] arguments)
        {
            throw new NotImplementedException("Python is not yet supported");
        }

        public static void Exec(string code, object p = null, object handle = null)
        {
            throw new NotImplementedException();
        }

        public static void Initialize()
        {
            throw new NotImplementedException();
        }

        public static void BeginAllowThreads()
        {
            throw new NotImplementedException();
        }

        public static void RunSimpleString(string v)
        {
            throw new NotImplementedException();
        }

        public static dynamic ImportModule(string v)
        {
            throw new NotImplementedException();
        }
    }

    public class PyList : IDisposable
    {
        public PyList(dynamic args = null)
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

        public void Append(dynamic items = null)
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

        public static bool IsDictType(PyObject headers)
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

        public static dynamic ToPython(this object T)
        {
            throw new NotImplementedException();
        }

        public static dynamic DefineDynamicAssembly(this AppDomain domain, AssemblyName name, AssemblyBuilderAccess an)
        {
            throw new NotImplementedException();
        }
    }

    public class PyString : PyObject
    {
        public PyString(string obj)
        {
            throw new NotImplementedException();
        }
        public static bool IsStringType(PyObject item)
        {
            throw new NotImplementedException();
        }
    }

    public class PyTuple
    {
        private PyObject[] pyObject;

        public PyTuple(PyObject[] pyObject)
        {
            this.pyObject = pyObject;
        }

        public static bool IsTupleType(dynamic value)
        {
            throw new NotImplementedException();
        }
    }

    public enum AssemblyBuilderAccess
    {
        Run = 1
    }
}