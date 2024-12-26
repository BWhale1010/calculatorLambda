using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathOperations
    {
        // 기본 사칙연산
        //public double Divide(double a, double b)// 나누기
        //{
        //    return a / b;
        //}

        // =========== 구조체는 CalculatorForm.cs 파일에 있습니다.

        public double Divide(double a, double b) => a / b;

        //public double Multiply(double a, double b) // 곱하기
        //{
        //    return a * b;
        //}

        public double Multiply(double a, double b) => a * b;
        //public double Subtract(double a, double b) // 뺴기
        //{
        //    return a - b;
        //}

        public double Subtract(double a, double b) => a - b;

        //public double Add(double a, double b) // 더하기
        //{
        //    return a + b;
        //}

        public double Add(double a, double b) => a + b;

        // 특수 연산
        //public double Inverse(double value)  // 1/x
        //{
        //    return 1 / value;
        //}

        public double Inverse(double value) => 1 / value;

        //public double Square(double value)   // x^2
        //{
        //    return value * value;
        //}

        public double Square(double value) => value * value;

        //public double SquareRoot(double value) // √x
        //{
        //    return Math.Pow(value, 0.5);
        //}

        public double SquareRoot(double value) => Math.Pow(value, 0.5);

        //public double PercentAddSubtract(double targetValue, double value) // targetValue * (value%)
        //{
        //    return targetValue * value / 100;
        //}


        public double Percent(double value) => value / 100;

        //public double ReverseSign(double value) // 현재 부호의 반대로 변경
        //{
        //    return value * -1;
        //}

        public double ReverseSign(double value) => value * -1;

    }
}
