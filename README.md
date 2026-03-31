# Calculator

Simple Windows Forms calculator app written in C# targeting .NET Framework 4.7.2.

## Overview

This small app provides a basic calculator UI with digit and operator buttons, a display, and support for simple arithmetic expressions. It is designed to be user-friendly and efficient for performing basic calculations.

## Prerequisites

- Windows
- Visual Studio 2022 (or later) with .NET desktop development workload
- .NET Framework 4.7.2

## Build and run

1. Open the solution in Visual Studio 2022.
2. Set `Calculator` as the startup project.
3. Build the solution: __Build > Build Solution__.
4. Run the app: __Debug > Start Debugging__ or press F5.

## Usage

- Click digit buttons (`0`–`9`) to enter numbers.
- Click operator buttons (`+`, `-`, `*`, `/`) to build expressions.
- Press `=` to evaluate the current expression.
- Press `C` to clear the entire expression.
- Press `CE` to clear the last entry (removes the last character).

The app evaluates the expression using `DataTable().Compute`, so it supports parentheses and standard arithmetic operators.

## Implementation notes

- UI class: `CalculatorGUI` (Windows Forms `Form`).
- The app appends button text to a `currentCalculation` string and displays it in a textbox `txtOutput`.
- Evaluation uses `new DataTable().Compute(currentCalculation, null)`.

### Security & Limitations

- `DataTable().Compute` evaluates expressions and can throw exceptions on malformed input. Input is not sandboxed; do not expose this as a service to untrusted input.
- This implementation handles basic arithmetic only; no advanced math functions (sin, cos, pow) are provided.

## Testing

- Manual testing by clicking buttons and verifying results.
- Edge cases: malformed expressions, divide-by-zero scenarios.
