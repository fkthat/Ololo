using Xunit;

namespace MidInterviewTest;

/*
    You are given an n x n 2D matrix representing an image, 
    rotate the image by 90 degrees (clockwise).
    
    Extra:
    You have to rotate the matrix in-place, which means you 
    have to modify the input 2D matrix directly. 
    DO NOT allocate another 2D matrix and do the rotation.
    
    Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
    Output: [[7,4,1],[8,5,2],[9,6,3]]
    
    1 2 3      7 4 1
    4 5 6  ->  8 5 2
    7 8 9      9 6 3
*/
public static class MatrixRotator
{
    public static int[][] Rotate(int[][] matrix)
    {
        throw new NotImplementedException();
    }
}

public class TestMatrixRotator
{
    [Theory]
    [InlineData(
         1, 2, 3, 4, 5, 6, 7, 8, 9,
         7, 4, 1, 8, 5, 2, 9, 6, 3 
    )]
    public void Test(params int[] input)
    {
        var originalMatrix = new int[3][];
        for (int i = 0; i < 3; i++)
        {
            originalMatrix[i] = new int[3];
            for (int j = 0; j < 3; j++)
            {
                originalMatrix[i][j] = input[i * 3 + j];
            }
        }
        var expectedMatrix = new int[3][];
        for (int i = 0; i < 3; i++)
        {
            expectedMatrix[i] = new int[3];
            for (int j = 0; j < 3; j++)
            {
                expectedMatrix[i][j] = input[i * 3 + j + 9];
            }
        }
        var actualMatrix = MatrixRotator.Rotate(originalMatrix);
        Assert.Equal(expectedMatrix, actualMatrix);
    }
  
}