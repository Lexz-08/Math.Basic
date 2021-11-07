using System;

namespace Math.Basic
{
	/// <summary>
	/// Allows math operations such as add, subtract, multiply, divide, power-of, and modulus.
	/// </summary>
	public static class MathOperations
	{
		#region Add Operations
		/// <summary>
		/// Adds 2 numbers together.
		/// </summary>
		/// <returns>The sum of <paramref name="Number1"/> and <paramref name="Number2"/>.</returns>
		public static byte Add(byte Number1, byte Number2) => (byte)(Number1 + Number2);
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static decimal Add(decimal Number1, decimal Number2) => Number1 + Number2;
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static double Add(double Number1, double Number2) => Number1 + Number2;
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static float Add(float Number1, float Number2) => Number1 + Number2;
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static int Add(int Number1, int Number2) => Number1 + Number2;
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static long Add(long Number1, long Number2) => Number1 + Number2;
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static sbyte Add(sbyte Number1, sbyte Number2) => (sbyte)(Number1 + Number2);
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static short Add(short Number1, short Number2) => (short)(Number1 + Number2);
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static uint Add(uint Number1, uint Number2) => Number1 + Number2;
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static ulong Add(ulong Number1, ulong Number2) => Number1 + Number2;
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static ushort Add(ushort Number1, ushort Number2) => (ushort)(Number1 + Number2);
		/// <summary>
		/// <inheritdoc cref="Add(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Add(byte, byte)"/></returns>
		public static IntPtr Add(IntPtr Number1, IntPtr Number2) => (IntPtr)((int)Number1 + (int)Number2);
		#endregion
		#region Subtraction Operations
		/// <summary>
		/// Subtracts <paramref name="Number2"/> from <paramref name="Number1"/>.
		/// </summary>
		/// <returns>The difference of <paramref name="Number1"/> and <paramref name="Number2"/>.</returns>
		public static byte Subtract(byte Number1, byte Number2) => (byte)(Number1 - Number2);
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static decimal Subtract(decimal Number1, decimal Number2) => Number1 - Number2;
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static double Subtract(double Number1, double Number2) => Number1 - Number2;
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static float Subtract(float Number1, float Number2) => Number1 - Number2;
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static int Subtract(int Number1, int Number2) => Number1 - Number2;
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static long Subtract(long Number1, long Number2) => Number1 - Number2;
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static sbyte Subtract(sbyte Number1, sbyte Number2) => (sbyte)(Number1 - Number2);
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static short Subtract(short Number1, short Number2) => (short)(Number1 - Number2);
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static uint Subtract(uint Number1, uint Number2) => Number1 - Number2;
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static ulong Subtract(ulong Number1, ulong Number2) => Number1 - Number2;
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static ushort Subtract(ushort Number1, ushort Number2) => (ushort)(Number1 - Number2);
		/// <summary>
		/// <inheritdoc cref="Subtract(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Subtract(byte, byte)"/></returns>
		public static IntPtr Subtract(IntPtr Number1, IntPtr Number2) => (IntPtr)((int)Number1 - (int)Number2);
		#endregion
		#region Multiplication Operations
		/// <summary>
		/// Multiplies 2 numbers.
		/// </summary>
		/// <returns>The product of <paramref name="Number1"/> and <paramref name="Number2"/>.</returns>
		public static byte Multiply(byte Number1, byte Number2) => (byte)(Number1 * Number2);
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static decimal Multiply(decimal Number1, decimal Number2) => Number1 * Number2;
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static double Multiply(double Number1, double Number2) => Number1 * Number2;
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static float Multiply(float Number1, float Number2) => Number1 * Number2;
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static int Multiply(int Number1, int Number2) => Number1 * Number2;
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static long Multiply(long Number1, long Number2) => Number1 * Number2;
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static sbyte Multiply(sbyte Number1, sbyte Number2) => (sbyte)(Number1 * Number2);
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static short Multiply(short Number1, short Number2) => (short)(Number1 * Number2);
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static uint Multiply(uint Number1, uint Number2) => Number1 * Number2;
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static ulong Multiply(ulong Number1, ulong Number2) => Number1 * Number2;
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static ushort Multiply(ushort Number1, ushort Number2) => (ushort)(Number1 * Number2);
		/// <summary>
		/// <inheritdoc cref="Multiply(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Multiply(byte, byte)"/></returns>
		public static IntPtr Multiply(IntPtr Number1, IntPtr Number2) => (IntPtr)((int)Number1 * (int)Number2);
		#endregion
		#region Division Operations
		/// <summary>
		/// Divides <paramref name="Number2"/> from <paramref name="Number1"/>.
		/// </summary>
		/// <returns>The quotient of <paramref name="Number1"/> and <paramref name="Number2"/>.</returns>
		public static byte Divide(byte Number1, byte Number2) => (byte)(Number1 / Number2);
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static decimal Divide(decimal Number1, decimal Number2) => Number1 / Number2;
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static double Divide(double Number1, double Number2) => Number1 / Number2;
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static float Divide(float Number1, float Number2) => Number1 / Number2;
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static int Divide(int Number1, int Number2) => Number1 / Number2;
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static long Divide(long Number1, long Number2) => Number1 / Number2;
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static sbyte Divide(sbyte Number1, sbyte Number2) => (sbyte)(Number1 / Number2);
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static short Divide(short Number1, short Number2) => (short)(Number1 / Number2);
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static uint Divide(uint Number1, uint Number2) => Number1 / Number2;
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static ulong Divide(ulong Number1, ulong Number2) => Number1 / Number2;
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static ushort Divide(ushort Number1, ushort Number2) => (ushort)(Number1 / Number2);
		/// <summary>
		/// <inheritdoc cref="Divide(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Divide(byte, byte)"/></returns>
		public static IntPtr Divide(IntPtr Number1, IntPtr Number2) => (IntPtr)((int)Number1 / (int)Number2);
		#endregion
		#region Exponential Operations
		/// <summary>
		/// Gets the exponential value of <paramref name="BaseNumber"/> using <paramref name="ExponentialNumber"/> as the exponent.
		/// </summary>
		/// <returns>The exponential value of <paramref name="BaseNumber"/> using <paramref name="ExponentialNumber"/> as the exponent.</returns>
		public static byte GetPowerOf(byte BaseNumber, byte ExponentialNumber) => (byte)System.Math.Pow(BaseNumber, ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static decimal GetPowerOf(decimal BaseNumber, decimal ExponentialNumber) => (decimal)System.Math.Pow((double)BaseNumber, (double)ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static double GetPowerOf(double BaseNumber, double ExponentialNumber) => System.Math.Pow(BaseNumber, ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static float GetPowerOf(float BaseNumber, float ExponentialNumber) => (float)System.Math.Pow(BaseNumber, ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static int GetPowerOf(int BaseNumber, int ExponentialNumber) => (int)System.Math.Pow(BaseNumber, ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static long GetPowerOf(long BaseNumber, long ExponentialNumber) => (long)System.Math.Pow(BaseNumber, ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static sbyte GetPowerOf(sbyte BaseNumber, sbyte ExponentialNumber) => (sbyte)System.Math.Pow(BaseNumber, ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static short GetPowerOf(short BaseNumber, short ExponentialNumber) => (short)System.Math.Pow(BaseNumber, ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static uint GetPowerOf(uint BaseNumber, uint ExponentialNumber) => (uint)System.Math.Pow(BaseNumber, ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static ulong GetPowerOf(ulong BaseNumber, ulong ExponentialNumber) => (ulong)System.Math.Pow(BaseNumber, ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static ushort GetPowerOf(ushort BaseNumber, ushort ExponentialNumber) => (ushort)System.Math.Pow(BaseNumber, ExponentialNumber);
		/// <summary>
		/// <inheritdoc cref="GetPowerOf(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="GetPowerOf(byte, byte)"/></returns>
		public static IntPtr GetPowerOf(IntPtr BaseNumber, IntPtr ExponentialNumber) => (IntPtr)System.Math.Pow((double)BaseNumber, (double)ExponentialNumber);
		#endregion
		#region Modulo Operations
		/// <summary>
		/// Gets the remainder of the division operation of 2 numbers.
		/// </summary>
		/// <returns>The remainder of the division of 2 numbers.</returns>
		public static byte Modulo(byte Number1, byte Number2) => (byte)(Number1 % Number2);
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static decimal Modulo(decimal Number1, decimal Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static double Modulo(double Number1, double Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static float Modulo(float Number1, float Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static int Modulo(int Number1, int Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static long Modulo(long Number1, long Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static sbyte Modulo(sbyte Number1, sbyte Number2) => (sbyte)(Number1 % Number2);
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static short Modulo(short Number1, short Number2) => (short)(Number1 % Number2);
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static uint Modulo(uint Number1, uint Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static ulong Modulo(ulong Number1, ulong Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static ushort Modulo(ushort Number1, ushort Number2) => (ushort)(Number1 % Number2);
		/// <summary>
		/// <inheritdoc cref="Modulo(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulo(byte, byte)"/></returns>
		public static IntPtr Modulo(IntPtr Number1, IntPtr Number2) => (IntPtr)((int)Number1 % (int)Number2);
		#endregion
		#region Average Operations
		/// <summary>
		/// Gets the average of a bunch of numbers.
		/// </summary>
		/// <returns>The average of the parameter <paramref name="Numbers"/>.</returns>
		public static byte Average(params byte[] Numbers)
		{
			byte result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result = (byte)(result / Numbers.Length);

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static decimal Average(params decimal[] Numbers)
		{
			decimal result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result /= Numbers.Length;

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static double Average(params double[] Numbers)
		{
			double result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result /= Numbers.Length;

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static float Average(params float[] Numbers)
		{
			float result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result /= Numbers.Length;

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static int Average(params int[] Numbers)
		{
			int result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result /= Numbers.Length;

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static long Average(params long[] Numbers)
		{
			long result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result /= Numbers.Length;

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static sbyte Average(params sbyte[] Numbers)
		{
			sbyte result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result = (sbyte)(result / Numbers.Length);

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static short Average(params short[] Numbers)
		{
			short result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result = (short)(result / Numbers.Length);

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static uint Average(params uint[] Numbers)
		{
			uint result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result = (uint)(result / Numbers.Length);

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static ulong Average(params ulong[] Numbers)
		{
			ulong result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result = result / (ulong)Numbers.Length;

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static ushort Average(params ushort[] Numbers)
		{
			ushort result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += Numbers[i];
			}

			result = (ushort)(result / Numbers.Length);

			return result;
		}
		/// <summary>
		/// <inheritdoc cref="Average(byte[])"/>
		/// </summary>
		/// <returns><inheritdoc cref="Average(byte[])"/></returns>
		public static IntPtr Average(params IntPtr[] Numbers)
		{
			int result = 0;

			for (int i = 0; i < Numbers.Length; i++)
			{
				result += (int)Numbers[i];
			}

			result = result / Numbers.Length;

			return (IntPtr)result;
		}
		#endregion
	}
}
