using LeetCode150Lib.Backtracking.OptimizationProblems;
using System.Text;

namespace LeetCode150Lib.Backtracking.EnumerationProblems
{
    /// <summary>
    ///
    /// </summary>
    public class N_Queens51 : IBacktrackingOperation<IList<IList<string>>>
    {
        public IList<IList<string>> Execute(params object[] parameters)
        {
            int Q = (int)parameters[0];
            //*** Step 1. for backtracking problem solving
            //Determine what DS for storing the result
            var solutions = new List<IList<string>>();  //a nested collection.
            //DS for store n x n board
            var board = new List<StringBuilder>();  //enumerable collection

            //Create the board and initialize each block with a '.' char
            //This can be view as n x n metrix, can denote with 2-D array or List<>.
            //We are use List<> this time.
            for (var i = 0; i < Q; i++)
            {
                board.Add(new()); //create a list of stringbuilder objects
                board[i].Append('.', Q); //append '.' Q times. string = "...."
            }

            //call back method, start at row = 0.
            backtrack(0, [], [], []);

            return solutions; //return and the end

            //*** Step 2. Figure out what parameter for the backtracking method.
            void backtrack(int row, HashSet<int> cols, HashSet<int> posDiag, HashSet<int> negDiag)
            {
                //*** Step 3. figure out Base case
                if (row == Q)
                {
                    //The goal of this line is to transform the board collection into a list of strings and add that list to the solutions collection.
                    solutions.Add(board.Select(x => x.ToString()).ToList());
                    return;
                }
                // *** Step 4. Validate the set's have these values.
                // if any of these condition true, iterate to next col
                for (var col = 0; col < Q; col++)
                {
                    //Console.WriteLine($" {new string('-', row)} Enter Backtrack: row = {row} col = {col}  posDiag = {row + col} , negDiag = {row - col} ");

                    //validate state
                    if (is_valid_state(row, col, cols, posDiag, negDiag))
                    {
                        continue;
                    }

                    //Under what condition add to the set on second pass?
                    PlaceQueen(row, col, cols, posDiag, negDiag, board);

                    //*** Step 4.recursion
                    backtrack(row + 1, cols, posDiag, negDiag);  //increment row

                    //backtracking by remove all from the set
                    board[row][col] = '.';
                    cols.Remove(col);
                    posDiag.Remove(row + col);
                    negDiag.Remove(row - col);
                    //Console.WriteLine(new string('-', row) + "Exit Backtrack: row = " + row + " col = " + col);
                }
            }
            // validate method
            bool is_valid_state(int row, int col, HashSet<int> cols, HashSet<int> posDiag, HashSet<int> negDiag) => cols.Contains(col) || posDiag.Contains(row + col) || negDiag.Contains(row - col);
            //place queen
            void PlaceQueen(int row, int col, HashSet<int> cols, HashSet<int> posDiag, HashSet<int> negDiag, IList<StringBuilder> board)
            {
                cols.Add(col);
                posDiag.Add(row + col);
                negDiag.Add(row - col);
                board[row][col] = 'Q';
            }
        }
    }
}