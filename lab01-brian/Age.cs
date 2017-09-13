using System;

namespace lab01_brian
{
    public class AgeInput
    {
        private const int _myAge = 32;
        public int Age;
        public AgeInput(int age)
        {
            this.Age = age;
        }

        public int Difference(int age)
        {
            return Math.Abs(_myAge - age);
        }
    }
}
