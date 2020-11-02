using System;

namespace Calculator
{
    public class Fraction : IResults
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction"/> class.
        /// </summary>
        public Fraction() { }

        
        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction"/> class.
        /// </summary>
        /// <param name="numerator">The numerator value.</param>
        /// <param name="denominator">The denominator value.</param>
        public Fraction(int numerator, int denominator)
        {
            if (numerator == 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(_numerator),
                    "Numerator is zero");
            }
            if (denominator == 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(_denominator),
                    "Denominator is zero"); 
            }
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        /// <summary>
        /// Getter and Setter for _numerator
        /// </summary>
        public int Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }

        /// <summary>
        /// Getter and Setter for _denominator.
        /// </summary>
        public int Denominator
        {
            get
            {
                return _denominator;
            }

            set
            {
                _denominator = value;
            }

        }
        
        /// <summary>
        /// method Addition adds two fraction.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Fraction Addition(Fraction other)
        {
            Fraction result = new Fraction
            {
                Numerator = (this.Numerator * other.Denominator) + (other.Numerator * this.Denominator),
                Denominator = this.Denominator * other.Denominator
            };
            return result;
        }

        /// <summary>
        /// method Subtraction subtracts two fraction.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Fraction Subtraction(Fraction other)
        {
            Fraction result = new Fraction
            {
                Numerator = (this.Numerator * other.Denominator) - (other.Numerator * this.Denominator),
                Denominator = this.Denominator * other.Denominator
            };
            return result;
        }

        /// <summary>
        /// method Multiplication multiplies two fraction.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Fraction Multiplication(Fraction other)
        {
            Fraction result = new Fraction
            {
                Numerator = this.Numerator * other.Numerator,
                Denominator = this.Denominator * other.Denominator
            };
            return result;
        }

        /// <summary>
        /// method Division divides the two fraction.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Fraction Division(Fraction other)
        {
            Fraction result = new Fraction
            {
                Numerator = this.Numerator * other.Denominator,
                Denominator = this.Denominator * other.Numerator
            };
            return result;
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }
}
