using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SimpleCalculator
{
    internal class CalculationStatement
    {
        private readonly ReadOnlyDictionary<char, CalculationOperator> _operatorMappings = new ReadOnlyDictionary<char, CalculationOperator>(new Dictionary<char, CalculationOperator>
        {
            {'+', CalculationOperator.Addition},
            {'-', CalculationOperator.Subtraction},
            {'*', CalculationOperator.Multiplication},
            {'/', CalculationOperator.Division},
        });

        public int Operand1 { get; set; }

        public int Operand2 { get; set; }

        public CalculationOperator Operator { get; set; }
        private int CalculationResult { get; }

        public CalculationStatement(char @operator, int operand1, int operand2)
        {
            Operator = _operatorMappings[@operator];
            Operand1 = operand1;
            Operand2 = operand2;
            CalculationResult = CalculateResult(Operator, Operand1, Operand2);
        }

        private int CalculateResult(CalculationOperator @operator, int operand1, int operand2)
        {
            switch (@operator)
            {
                case CalculationOperator.Addition:
                    return operand1 + operand2;
                case CalculationOperator.Subtraction:
                    return operand1 - operand2;
                case CalculationOperator.Multiplication:
                    return operand1 * operand2;
                case CalculationOperator.Division:
                    return operand1 / operand2;
                default:
                    throw new InvalidOperationException("Invalid operator.");
            }
        }

        public int GetResult()
        {
            return CalculationResult;
        }
    }
}