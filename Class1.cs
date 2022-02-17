using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        public string Name;

        private static Class1 instance = null;

        public String Value;

        protected Class1() {
           
        }

        public static Class1 Instance()
        {
           
                if (instance == null) {
                    instance = new Class1();
                }
                return instance;
           
        }

        public void SetValue(String valor){

            Value = valor;

        }

        public String GetValue() {
            return "Hola " + Value;
        }
    }
}
