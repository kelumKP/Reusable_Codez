using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLMVCApp.SingletonImplement
{
    public sealed class SingletonClass
    {
        private SingletonClass()
        {

        }

        private static readonly Lazy<SingletonClass> instance = new Lazy<SingletonClass>(() => new SingletonClass());

        public static SingletonClass GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public string Multiplication(string cValue)
        {
            return (Int32.Parse(cValue) * Int32.Parse(cValue)).ToString();
        }
    }
}
