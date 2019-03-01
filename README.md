# Environment
- Operating System: Windows
- Framework: .NET Framework, Console Program


# How to setup
1. Use Visual Studio 2017 to build the solution file SimpleCalculator.sln.
2. Or run the command `msbuild SimpleCalculator.sln`.

# How to use
1. Run the built file SimpleCalculator.exe
2. You can input simple calculation with 2 operands and 1 operator licludes +, -, *, /. You can not enter any other redundant characters. And the operands and the calculation result only accept positive integers in the range [0, 2147483647].

Examples:
- 1+2 => 3
- 8*7 => 56
- 3-2 => 1
- 9/3 => 2
- 0+3 => 3
- 8/3 => 2
- 2147483647+100 => invalid
- 100-200 => invalid

