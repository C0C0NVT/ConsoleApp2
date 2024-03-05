class Program
{
    static void Main()
    {
        // DECLARATION FOR VARIABLE RND WHICH WILL BE USED THROUGHOUT THE PROGRAM
        Random rnd = new Random();
        // INTRODUCTION + INSTRUCTIONS BY ME
        Console.WriteLine("   Good day dear user and welcome to my Matrix Calculator!   ");
        Console.WriteLine("=============================================================");
        Console.WriteLine("\n---------------");
        Console.WriteLine("   MECHANICS   ");
        Console.WriteLine("---------------\n");
        Console.WriteLine("The program I made will be generating numbers within the matrix and the number or amount");
        Console.WriteLine("of them will be depending on the numbers of rows & columns you shall be inputting for me!\n");
        Console.WriteLine("----------------------");
        Console.WriteLine("   MATRIX OPERATIONS   ");
        Console.WriteLine("----------------------");

        // This basically shows how the program will always run unless it ends/breaks.
        while (true)
        {
            //Set of instructions for the user to follow. This is for the four operations.
            Console.WriteLine("\n\nPlease choose an operation you want me to use! (Input the number only) : ");
            Console.WriteLine("[1] TRANSPOSITION");
            Console.WriteLine("[2] ADDITION");
            Console.WriteLine("[3] SUBTRACTION");
            Console.WriteLine("[4] MULTIPLICATION");
            Console.Write("\nPlease place your input here! ~~~> ");

            //The program will read the user input and start comparing it with the if else conditions below.
            int operationchoice = int.Parse(Console.ReadLine());

            //If user input is 1, the program will run the transposition program.
            if (operationchoice == 1) // TRANSPOSE
            {
                //Provide a clean output display
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("   TRANSPOSITION STARTS HERE   ");
                Console.WriteLine("-------------------------------");
                //Input array dimensions.
                Console.Write("\nInput the number of rows you wish for the matrix    ~~> ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Input the number of columns you wish for the matrix  ~~> ");
                int col = int.Parse(Console.ReadLine());

                //Make a 2D array with dimensions specified by the user as shown above.
                int[,] matrix = new int[row, col];

                //Iterate through each row
                for (int x = 0; x < row; x++)
                {
                    //Iterate through each column
                    for (int y = 0; y < col; y++)
                    {
                        //Assigns a random value between 1-10 for the value x,y within the matrix!
                        matrix[x, y] = rnd.Next(1, 11);
                    }
                }

                //Blocks of code below prints the matrices outputs

                Console.WriteLine("\nFirst generated version of the matrix is this one! : ");
                //Iterate through each row
                for (int x = 0; x < row; x++)
                {
                    //Iterate through each column
                    for (int y = 0; y < col; y++)
                    {
                        //Prints the value at position x,y within the matrix. This is followed by a tab character!
                        Console.Write(matrix[x, y] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nThis is the TRANSPOSED Matrix! : ");
                //Iterate through the column first now
                for (int x = 0; x < col; x++)
                {
                    //Then iterate through the rows
                    for (int y = 0; y < row; y++)
                    {
                        //As you can see here, the rows and columns are swapped.
                        Console.Write(matrix[y, x] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("   DONE IN FINDING THE TRANSPOSITIONED MATRIX. THANK YOU!!   ");
                Console.WriteLine("-----------------------------------------------------------\n\n");
                //End the program
                break;
            }

            //If user input is 2, the program will run the ADDITION program.
            else if (operationchoice == 2)
            {
                //Instructions + User inputs for dimensions
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("   ADDITION STARTS HERE   ");
                Console.WriteLine("--------------------------");
                Console.Write("Input the number of rows you wish for the matrix    ~~> ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Input the number of columns you wish for the matrix  ~~> ");
                int col = int.Parse(Console.ReadLine());

                //Dimensions of the multi-dimensional arrays below are user input as shown above.
                int[,] matrix1add = new int[row, col];
                int[,] matrix2add = new int[row, col];
                int[,] matrix3add = new int[row, col];

                // Generate random values for matrix1add and matrix2add
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        matrix1add[x, y] = rnd.Next(1, 11);
                        matrix2add[x, y] = rnd.Next(1, 11);
                    }
                }
                //Output of 1st matrix
                Console.WriteLine("\nOutput of randomly generated 1ST Matrix: \n");
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        Console.Write(matrix1add[x, y] + "\t");
                    }
                    Console.WriteLine();
                }
                //Output of 2nd matrix
                Console.WriteLine("\nOutput of randomly generated 2ND Matrix: \n");
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        Console.Write(matrix2add[x, y] + "\t");
                    }
                    Console.WriteLine();
                }

                // This is where we perform the matrix addition!
                //Iterate through each row
                for (int x = 0; x < row; x++)
                {
                    //Iterate through each column
                    for (int y = 0; y < col; y++)
                    {
                        //Matrix3add is the matrix with the sums of each respective indexes of the 1st and 2nd arrays.
                        matrix3add[x, y] = matrix1add[x, y] + matrix2add[x, y];
                    }
                }
                //Final Addition Output after the process
                Console.WriteLine("\nHere is the SUM Matrix!!!\n");
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        Console.Write(matrix3add[x, y] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("      DONE IN FINDING THE SUMMED UP MATRIX. THANK YOU! !     ");
                Console.WriteLine("-----------------------------------------------------------\n\n");
                break;
            }

            //If user input is 3, the program will run the subtraction program.
            else if (operationchoice == 3) // SUBTRACTION
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("   SUBTRACTION STARTS HERE   ");
                Console.WriteLine("-----------------------------");
                Console.Write("Input the number of rows you wish for the matrix    ~~> ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Input the number of columns you wish for the matrix  ~~> ");
                int col = int.Parse(Console.ReadLine());

                int[,] matrix1sub = new int[row, col];
                int[,] matrix2sub = new int[row, col];
                int[,] matrix3sub = new int[row, col];

                // Generate random values for matrix1 and matrix2's indexes
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        matrix1sub[x, y] = rnd.Next(1, 11);
                        matrix2sub[x, y] = rnd.Next(1, 11);
                    }
                }
                //1st Matrix Output that is randomly generated
                Console.WriteLine("\nOutput of randomly generated 1ST Matrix: \n");
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        Console.Write(matrix1sub[x, y] + "\t");
                    }
                    Console.WriteLine();
                }
                //2nd Matrix Output that is randomly generated
                Console.WriteLine("\nOutput of randomly generated 2ND Matrix: \n");
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        Console.Write(matrix2sub[x, y] + "\t");
                    }
                    Console.WriteLine();
                }
                //This is the process to finding the difference of each number within the matrices.
                //Iterate through each row
                for (int x = 0; x < row; x++)
                {
                    //Iterate through each column
                    for (int y = 0; y < col; y++)
                    {
                        //Each number in the 3rd matrix is Number in matrix 1 minus Number in matrix 2
                        matrix3sub[x, y] = matrix1sub[x, y] - matrix2sub[x, y];
                    }
                }
                //Outputs the final matrix which has the differences!
                Console.WriteLine("\nHere is the DIFFERENCE Matrix!!!\n");
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        Console.Write(matrix3sub[x, y] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("      DONE IN FINDING THE SUBTRACTED MATRIX. THANK YOU! !    ");
                Console.WriteLine("-----------------------------------------------------------\n\n");
                break;
            }

            //If user input is 4, the program will run the MULTIPLICATION program.
            else if (operationchoice == 4) 
            {
                //Instructions
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("   MULTIPLICATION STARTS HERE   ");
                Console.WriteLine("--------------------------------");
                Console.Write("Input the number of rows you wish for the matrix    ~~> ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Input the number of columns you wish for the matrix  ~~> ");
                int col = int.Parse(Console.ReadLine());
                //Matrices for this block of code uses multidimensional array with dimension based on user input.
                int[,] matrix1prod = new int[row, col];
                int[,] matrix2prod = new int[col, row]; // This one is a transposed version.
                int[,] matrix3prod = new int[row, row];

                // Generate random values between 1-10 for matrix1prod and matrix2prod
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        matrix1prod[x, y] = rnd.Next(1, 11);
                        matrix2prod[y, x] = rnd.Next(1, 11); // Transposed version; As you can see x and y are switched
                    }
                }

                Console.WriteLine("\nOutput of randomly generated 1ST Matrix: \n");
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        Console.Write(matrix1prod[x, y] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n[[TRANSPOSED!!]] Output of randomly generated 2ND Matrix: \n");
                for (int x = 0; x < col; x++)
                {
                    for (int y = 0; y < row; y++)
                    {
                        Console.Write(matrix2prod[x, y] + "\t");
                    }
                    Console.WriteLine();
                }

                // Perform matrix multiplication
                // Iterate through the rows of matrix3prod (variable 'i' represents current row index)
                for (int i = 0; i < row; i++)
                {
                    //Iterate through the columns of matrix3prod (variable 'j' represents current column index)
                    for (int j = 0; j < row; j++)
                    {
                        //I am declaring an integer variable called "sum" to store the sum of the products for each element in the resulting matrix.
                        int sum = 0;
                        //In this loop, it iterates through columns of matrix1prod and rows of matrix2prod (variable 'k' represents current index for the shared dimensions)
                        for (int k = 0; k < col; k++)
                        {
                            //For each element in matrix3prod, program calculates the sum of the products
                            //matrix1prod[i, k] represents value from row i and k column of 1st matrix
                            //matrix2prod[k, j] represents value from row k and j column of 2nd matrix
                            sum += matrix1prod[i, k] * matrix2prod[k, j]; // You multiply the 2 values and add the result to the existing sum
                        }
                        // The calculated sum for the current element is assigned to the corresponding position in the matrix3prod
                        matrix3prod[i, j] = sum;
                    }
                }

                //Outputs the final matrix which has the multiplication of index results!
                Console.WriteLine("\nHere is the PRODUCT Matrix!!!\n");
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < row; y++)
                    {
                        Console.Write(matrix3prod[x, y] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("       DONE IN FINDING THE MATRIX WITH PRODUCTS. TY!!!       ");
                Console.WriteLine("-----------------------------------------------------------\n\n");
                break;
            }

            // If user input doesn't match any of the 4 conditions above, run the block of code below.
            else
            {
                Console.WriteLine("\nThat input is invalid! Please only choose between the numbers 1-4 next time.\n\n");
                break;
            }
        }
    }
}