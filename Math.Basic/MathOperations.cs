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
		#region Modulus Operations
		/// <summary>
		/// Gets the remainder of the division operation of 2 numbers.
		/// </summary>
		/// <returns>The remainder of the division of 2 numbers.</returns>
		public static byte Modulus(byte Number1, byte Number2) => (byte)(Number1 % Number2);
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static decimal Modulus(decimal Number1, decimal Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static double Modulus(double Number1, double Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static float Modulus(float Number1, float Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static int Modulus(int Number1, int Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static long Modulus(long Number1, long Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static sbyte Modulus(sbyte Number1, sbyte Number2) => (sbyte)(Number1 % Number2);
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static short Modulus(short Number1, short Number2) => (short)(Number1 % Number2);
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static uint Modulus(uint Number1, uint Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static ulong Modulus(ulong Number1, ulong Number2) => Number1 % Number2;
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static ushort Modulus(ushort Number1, ushort Number2) => (ushort)(Number1 % Number2);
		/// <summary>
		/// <inheritdoc cref="Modulus(byte, byte)"/>
		/// </summary>
		/// <returns><inheritdoc cref="Modulus(byte, byte)"/></returns>
		public static IntPtr Modulus(IntPtr Number1, IntPtr Number2) => (IntPtr)((int)Number1 % (int)Number2);
		#endregion
	}
}
