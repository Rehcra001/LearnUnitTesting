namespace LeetCodeSolutionsLibrary.ArraysAndStrings
{
    public static class MultiDimensionalArrays
    {
        public static int[] FindDiagonalOrder(int[][] mat)
        {
            int length = mat.Length * mat[0].Length;
            int[] arr = new int[length];

            int row = 0;
            int col = 0;

            bool MoveLeftUp = true; //if was moving up and left
            
            for (int i = 0; i < length; i++)
            {
                arr[i] = mat[row][col];

                if (MoveLeftUp)
                {
                    //check if top or right hit
                    if (row == 0 && col ==  0 && mat[0].Length > 1)
                    {
                        MoveLeftUp = false;
                        //At top left corner
                        //move one right
                        col++;
                    }
                    else if (row > 0 && col == mat[0].Length - 1)
                    {
                        MoveLeftUp = false;
                        //at right side but not touching top
                        //move one down
                        row++;
                    }
                    else if (row == 0 && col < mat[0].Length - 1)
                    {
                        MoveLeftUp = false;
                        //Top but not toauching right
                        //move right
                        col++;
                    }
                    else if (row == 0 && col == mat[0].Length - 1)
                    {
                        MoveLeftUp = false;
                        //Top right corner
                        //move down
                        row++;
                    }
                    else
                    {
                        //move up and left
                        row--;
                        col++;
                    }
                }
                else
                {
                    //check if left or bottom hit
                    if (row == mat.Length - 1 && col == 0 && mat[0].Length > 1)
                    {
                        MoveLeftUp = true;
                        //bottom left corner
                        //move right
                        col++;
                    }
                    else if (row == mat.Length - 1 && col > 0)
                    {
                        MoveLeftUp = true;
                        //
                        //move right
                        col++;
                    }
                    else if (row < mat.Length - 1 && col == 0)
                    {
                        MoveLeftUp = true;
                        //Bottom hit but not left
                        //move down
                        row++;
                    }
                    else
                    {
                        row++;
                        col--;
                    }
                }
            }

            return arr;
        }

        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> results = new List<int>();
            int length = matrix.Length * matrix[0].Length;
            int right = matrix[0].Length - 1;
            int bottom = matrix.Length - 1;
            int left = 0;
            int top = 0;
            int row = 0;
            int col = 0;

            string direction = "Right";

            while (length > 0)
            {
                switch (direction)
                {
                    case "Right":
                        while (col <= right)
                        {
                            results.Add(matrix[row][col]);
                            col++;
                            length--;
                        }
                        row++;
                        col--;
                        top++;
                        direction = "Down";
                        break;
                    case "Down":
                        while (row <= bottom)
                        {
                            results.Add(matrix[row][col]);
                            row++;
                            length--;
                        }
                        col--;
                        row--;
                        right--;
                        direction = "Left";
                        break;
                    case "Left":
                        while (col >= left)
                        {
                            results.Add(matrix[row][col]);
                            col--;
                            length--;
                        }
                        col++;
                        row--;
                        bottom--;
                        direction = "Up";
                        break;
                    case "Up":
                        while (row >= top)
                        {
                            results.Add(matrix[row][col]);
                            row--;
                            length--;
                        }
                        row++;
                        col++;
                        left++;
                        direction = "Right";
                        break;                }
            }
            return results;
        }

        /// <summary>
        /// Generates pascals triangle for the required number of rowns
        /// </summary>
        /// <param name="numRows">
        /// Takes in an integer of the number of row to generate
        /// </param>
        /// <returns>
        /// Returns an IList<IList<int>>
        /// </returns>
        public static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> pascal = new List<IList<int>>();

            if (numRows == 1)
            {
                pascal.Add(new List<int>() { 1 });
            }
            else if (numRows == 2)
            {
                pascal.Add(new List<int>() { 1 });
                pascal.Add(new List<int>() { 1, 1 });
            }
            else
            {
                pascal.Add(new List<int>() { 1 });
                pascal.Add(new List<int>() { 1, 1 });
                //start with the third row
                for (int i = 2; i < numRows; i++)
                {
                    pascal.Add(new List<int>());

                    
                    pascal[i].Add(1);
                    for (int j = 1; j < pascal[i - 1].Count; j++)
                    {
                        pascal[i].Add(pascal[i - 1][j - 1] + pascal[i - 1][j]);
                    }
                    pascal[i].Add(1);
                }
            }
            

            return pascal;
        }
    }
}
