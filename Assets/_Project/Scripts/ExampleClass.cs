//using System;

namespace MyNamespace
{
    public class ExampleClass
    {
        public string name;
        private int age;
        private float attackPower;
        public static int Number;

        void SetNewName(string newName)
        {
            name = newName;
        }

        bool IsRightHanded()
        {
            return true;
        }

        bool CanTurn()
        {
            return false;
        }
    }
}