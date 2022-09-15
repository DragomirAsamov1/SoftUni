int lines = int.Parse(Console.ReadLine());

int[][] pascalTriangle = new int [lines][];

for (int row = 0; row < lines; row++) {
    pascalTriangle[row] = new int[row + 1];
    pascalTriangle[row][0] = 1;
    pascalTriangle[row][^1] = 1;

    for (int col = 1; col < row; col++) {
        pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
    }
}

for (int row = 0; row < lines; row++) {
    Console.WriteLine(String.Join(' ', pascalTriangle[row]));
}