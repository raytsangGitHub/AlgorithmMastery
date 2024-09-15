using LeetCode150Lib.Backtracking.OptimizationProblems;
using System.Text;

namespace LeetCode150Lib.Backtracking.EnumerationProblems
{
    /// <summary>
    /// Enumeration Problem:  Find all possible feasible solutions to the problems of this type.
    /// </summary>
    public class GenerateParentheses22 : IBacktrackingOperation<IList<string>>
    {
        /// <summary>
        /// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
        /// Input: n = 3
        /// Output: ["((()))","(()())","(())()","()(())","()()()"]
        /// </summary>
        public IList<string> Execute(params object[] parameters)
        {
            var n = (int)parameters[0];
            if (n <= 0) { return null; }
            //pick DS for final resul
            var result = new List<string>();
            //don't use stack, because it's reverse the order of paratheses.
            // var temp = new Stack<string>();

            backtrack(new StringBuilder(), 0, 0);
            return result;

            //Solve by looking into its backtracking tree.
            void backtrack(StringBuilder state, int openCount, int closedCount)
            {
                //base case valid IIF open == closed ==n
                if (openCount == n && closedCount == n)
                {
                    result.Add(state.ToString());
                    return;
                }

                //validation://add open if open<n
                //add close if closed < open
                if (openCount < n)
                {
                    state.Append('(');
                    backtrack(state, openCount + 1, closedCount);
                    state.Remove(state.Length - 1, 1);
                }

                if (closedCount < openCount)
                {
                    state.Append(')');
                    backtrack(state, openCount, closedCount + 1);
                    state.Remove(state.Length - 1, 1);
                }
            }
        }
    }
}