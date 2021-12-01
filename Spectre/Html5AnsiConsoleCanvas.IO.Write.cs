﻿using Spectre.Console;
using Spectre.Console.Rendering;

namespace HACC.Spectre;

//
// Summary:
//     Represents the standard input, output, and error streams for console applications.
//     This class cannot be inherited.
public partial class Html5AnsiConsoleCanvas : IAnsiConsole
{
    public void Write(IRenderable renderable)
    {
        throw new NotImplementedException();
    }

    //
    // Summary:
    //     Writes the text representation of the specified Boolean value to the standard
    //     output stream.
    //
    // Parameters:
    //   value:
    //     The value to write.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(bool value)
    {
        InternalCharacterBuffer.WriteLine(
            line: Convert.ToString(value: value),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the specified Unicode character value to the standard output stream.
    //
    // Parameters:
    //   value:
    //     The value to write.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(char value)
    {
        InternalCharacterBuffer.WriteChar(
            character: Convert.ToString(value: value),
            characterEffects: null);
    }

    //
    // Summary:
    //     Writes the specified array of Unicode characters to the standard output stream.
    //
    // Parameters:
    //   buffer:
    //     A Unicode character array.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(char[]? buffer)
    {
        var value = buffer is null ? string.Empty : new string(value: buffer);
        InternalCharacterBuffer.WriteLine(
            line: value,
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the specified subarray of Unicode characters to the standard output stream.
    //
    // Parameters:
    //   buffer:
    //     An array of Unicode characters.
    //
    //   index:
    //     The starting position in buffer.
    //
    //   count:
    //     The number of characters to write.
    //
    // Exceptions:
    //   T:System.ArgumentNullException:
    //     buffer is null.
    //
    //   T:System.ArgumentOutOfRangeException:
    //     index or count is less than zero.
    //
    //   T:System.ArgumentException:
    //     index plus count specify a position that is not within buffer.
    //
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(char[] buffer, int index, int count)
    {
        var value = new string(value: buffer).Substring(
            startIndex: index,
            length: count);
        InternalCharacterBuffer.WriteLine(
            line: value,
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified System.Decimal value to the standard
    //     output stream.
    //
    // Parameters:
    //   value:
    //     The value to write.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(decimal value)
    {
        InternalCharacterBuffer.WriteLine(
            line: Convert.ToString(value: value),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified double-precision floating-point
    //     value to the standard output stream.
    //
    // Parameters:
    //   value:
    //     The value to write.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(double value)
    {
        InternalCharacterBuffer.WriteLine(
            line: Convert.ToString(value: value),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified 32-bit signed integer value to
    //     the standard output stream.
    //
    // Parameters:
    //   value:
    //     The value to write.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(int value)
    {
        InternalCharacterBuffer.WriteLine(
            line: Convert.ToString(value: value),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified 64-bit signed integer value to
    //     the standard output stream.
    //
    // Parameters:
    //   value:
    //     The value to write.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(long value)
    {
        InternalCharacterBuffer.WriteLine(
            line: Convert.ToString(value: value),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified object to the standard output
    //     stream.
    //
    // Parameters:
    //   value:
    //     The value to write, or null.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(object? value)
    {
        var valueString = value is null ? string.Empty : Convert.ToString(value: value);
        InternalCharacterBuffer.WriteLine(
            line: valueString,
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified single-precision floating-point
    //     value to the standard output stream.
    //
    // Parameters:
    //   value:
    //     The value to write.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(float value)
    {
        InternalCharacterBuffer.WriteLine(
            line: Convert.ToString(value: value),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the specified string value to the standard output stream.
    //
    // Parameters:
    //   value:
    //     The value to write.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    public void Write(string? value)
    {
        var nonNullString = string.IsNullOrEmpty(value: value) ? string.Empty : value;
        InternalCharacterBuffer.WriteLine(
            line: nonNullString,
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified object to the standard output
    //     stream using the specified format information.
    //
    // Parameters:
    //   format:
    //     A composite format string.
    //
    //   arg0:
    //     An object to write using format.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    //
    //   T:System.ArgumentNullException:
    //     format is null.
    //
    //   T:System.FormatException:
    //     The format specification in format is invalid.
    public void Write(string format, object? arg0)
    {
        InternalCharacterBuffer.WriteLine(
            line: string.Format(format: format, arg0: arg0),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified objects to the standard output
    //     stream using the specified format information.
    //
    // Parameters:
    //   format:
    //     A composite format string.
    //
    //   arg0:
    //     The first object to write using format.
    //
    //   arg1:
    //     The second object to write using format.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    //
    //   T:System.ArgumentNullException:
    //     format is null.
    //
    //   T:System.FormatException:
    //     The format specification in format is invalid.
    public void Write(string format, object? arg0, object? arg1)
    {
        InternalCharacterBuffer.WriteLine(
            line: string.Format(
                format: format,
                arg0: arg0,
                arg1: arg1),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified objects to the standard output
    //     stream using the specified format information.
    //
    // Parameters:
    //   format:
    //     A composite format string.
    //
    //   arg0:
    //     The first object to write using format.
    //
    //   arg1:
    //     The second object to write using format.
    //
    //   arg2:
    //     The third object to write using format.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    //
    //   T:System.ArgumentNullException:
    //     format is null.
    //
    //   T:System.FormatException:
    //     The format specification in format is invalid.
    public void Write(string format, object? arg0, object? arg1, object? arg2)
    {
        InternalCharacterBuffer.WriteLine(
            line: string.Format(
                format: format,
                arg0: arg0,
                arg1: arg1,
                arg2: arg2),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified array of objects to the standard
    //     output stream using the specified format information.
    //
    // Parameters:
    //   format:
    //     A composite format string.
    //
    //   arg:
    //     An array of objects to write using format.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    //
    //   T:System.ArgumentNullException:
    //     format or arg is null.
    //
    //   T:System.FormatException:
    //     The format specification in format is invalid.
    public void Write(string format, params object?[]? arg)
    {
        InternalCharacterBuffer.WriteLine(
            line: string.Format(
                format: format,
                arg0: arg),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified 32-bit unsigned integer value
    //     to the standard output stream.
    //
    // Parameters:
    //   value:
    //     The value to write.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    [CLSCompliant(isCompliant: false)]
    public void Write(uint value)
    {
        InternalCharacterBuffer.WriteLine(
            line: Convert.ToString(value: value),
            characterEffects: null,
            automaticNewLine: false);
    }

    //
    // Summary:
    //     Writes the text representation of the specified 64-bit unsigned integer value
    //     to the standard output stream.
    //
    // Parameters:
    //   value:
    //     The value to write.
    //
    // Exceptions:
    //   T:System.IO.IOException:
    //     An I/O error occurred.
    [CLSCompliant(isCompliant: false)]
    public void Write(ulong value)
    {
        InternalCharacterBuffer.WriteLine(
            line: Convert.ToString(value: value),
            characterEffects: null,
            automaticNewLine: false);
    }
}