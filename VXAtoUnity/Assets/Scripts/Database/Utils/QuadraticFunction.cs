using UnityEngine;

namespace VXAtoUnity.Database.Utils
{
    public class QuadraticFunction
    {
        /// <summary>
        /// x^2 component
        /// </summary>
        public float A { get; private set; }
        /// <summary>
        /// x component
        /// </summary>
        public float B { get; private set; }
        /// <summary>
        /// variable-less component
        /// </summary>
        public float C { get; private set; }

        /// <summary>
        /// Creates a quadratic function
        /// </summary>
        /// <param name="a">x^2 component</param>
        /// <param name="b">x component</param>
        /// <param name="c">variable-less component</param>
        public QuadraticFunction(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Get the result of the defined quadratic function, given a variable X.
        /// </summary>
        /// <param name="x">Parameter of the quadratic function.</param>
        /// <returns>The result of the quadratic function, given x as a variable.</returns>
        public float GetResult(float x)
        {
            return Mathf.Pow(x, 2) * A + x * B + C;
        }
    }
}
