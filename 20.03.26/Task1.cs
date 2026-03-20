using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5.Variant00
{
    public class Task1
    {
        public struct Number : INumber
        {
            // Поля
            private double _real;
            // Свойства
            public double Real => _real;
            public double Abs => Math.Abs(_real);
            public int Sign
            {
                get
                {
                    if (_real > 0)
                        return 1;
                    if (_real < 0)
                        return -1;
                    return 0;
                }
            }
            // Конструктор

            // Number num = new Number(-5, 2, 102)
            public Number(double real)
            {
                _real = real;
            }
            // Методы
            public void Sum (INumber other)
            {
                _real += other.Real;
            }
            public void Sub(INumber other)
            {
                _real -= other.Real;
            }
            public void Mul(INumber other)
            {
                _real *= other.Real;
            }
            public void Div(INumber other)
            {
                _real /= other.Real;
            }
            public void Neg()
            {
                _real = -_real;
            }
        }
    }
}
