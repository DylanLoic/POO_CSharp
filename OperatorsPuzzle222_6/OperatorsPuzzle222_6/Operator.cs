/*
 * Author : Schito Dylan, Sutter Antoine
 * Date : 01.10.2018
 * File : Operators.cs
 * Description : Allow to process the operation delegate 
 */

using System.Collections.Generic;
using System.Linq;

namespace OperatorsPuzzle222_6
{
    public delegate int OperationDelegate(int a, int b);
    public class Operator
    {
        #region Fields
        private string _symbol;
        private int _priority;
        private OperationDelegate _operation;
        #endregion

        #region Properties
        private string Symbol { get => _symbol; set => _symbol = value; }
        public int Priority { get => _priority; private set => _priority = value; }
        private OperationDelegate Operation { get => _operation; set => _operation = value; }
        #endregion

        #region Methods
        #region Constructor
        /// <summary>
        /// dedicated constructor 
        /// </summary>
        public Operator(string pSymbol, int pPriority, OperationDelegate pDelegate)
        {
            this.Symbol = pSymbol;
            this.Priority = pPriority;
            this.Operation = pDelegate;
        }
        #endregion

        /// <summary>
        /// Invode the delegate to do the operation
        /// </summary>
        public int Execute(int a, int b)
        {
            return this.Operation.Invoke(a, b);
        }

        /// <summary>
        /// Allow's to return a operators list to ordered's priority
        /// </summary>
        /// <returns>List of operators</returns>
        static public List<Operator> OrderByPriority(params Operator[] operators)// op1, Operator op2, int number)
        {
            return operators.OrderByDescending(op => op.Priority).ToList();
        }

        public override string ToString()
        {
            return this.Symbol;
        }
        #endregion
    }
}
