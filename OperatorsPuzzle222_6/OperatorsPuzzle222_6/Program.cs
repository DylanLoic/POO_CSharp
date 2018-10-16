/*
 * Author : Schito Dylan, Sutter Antoine
 * Date : 01.10.2018
 * File : Program.cs
 * Description : Allow to process the operation delegate 
 */
using System;
using System.Collections.Generic;

namespace OperatorsPuzzle222_6
{
    class Program
    {
        private const int TARGET_NUMBER = 6;

        static void Main(string[] args)
        {
            List<Operator> operators = new List<Operator>{
                new Operator("+", 12, (a, b) => a + b),
                new Operator("-", 12, (a, b) => a - b),
                new Operator("*", 13, (a, b) => a * b),
                new Operator("/", 13, (a, b) => a / b),
            };
            
            for (int i = 1; i <= TARGET_NUMBER; i++)
            {
                operators.ForEach(op1 =>
               {
                   operators.ForEach(op2 =>
                   {
                       int result = i;
                       Operator.OrderByPriority(op1, op2).ForEach(op =>
                       {
                           result = op.Execute(result, i);
                       });

                       if (result == TARGET_NUMBER)
                       {
                           Console.WriteLine($"{i} {op1} {i} {op2} {i} = {TARGET_NUMBER}");
                       }
                   });
               });
            }
        }
    }
}
