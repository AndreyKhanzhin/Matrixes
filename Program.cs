string N;
int n;
string a;
string b;
int ai;
int bi;

do{
    Console.WriteLine("Введите размерность квадратной матрицы, и границы диапазона, в пределах которого будет заполняться матрицы, которыми являются целые положительные числа. При ошибке программа ввода начнётся заново.");
    N = Console.ReadLine();
    Console.WriteLine("Теперь введите границы диапазонов.");
    a = Console.ReadLine();
    b = Console.ReadLine();
}
while (N == null || int.TryParse(N, out n) == false || n <= 0 || int.TryParse(a, out ai) == false || int.TryParse(b, out bi) == false);

int[,] A = new int[n, n];
int[,] B = new int[n, n];

Random rnd = new Random();

void MatrixFill (int[,] matrix){
    for (int i = 0; i < n; i++){
        for (int j = 0; j < n; j++){
            matrix[i, j] = rnd.Next(Math.Min(ai, bi), Math.Max(ai, bi) + 1);
        }
    }
    for (int i = 0; i < n; i++){
        for (int j = 0; j < n; j++){
            Console.Write("|" + matrix[i, j] + "|");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Sum (int[,] matrix1, int[,] matrix2){
    int[,] C = new int[n, n];
    for (int i = 0; i < n; i++){
        for (int j = 0; j < n; j++){
            C[i, j] = matrix1[i, j] + matrix2[i, j];
        }
    }
    for (int i = 0; i < n; i++){
        for (int j = 0; j < n; j++){
            Console.Write("|" + C[i, j] + "|");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Raz(int[,] matrix1, int[,] matrix2){
    int[,] C = new int[n, n];
    for (int i = 0; i < n; i++){
        for (int j = 0; j < n; j++){
            C[i, j] = matrix1[i, j] - matrix2[i, j];
        }
    }
    for (int i = 0; i < n; i++){
        for (int j = 0; j < n; j++){
            Console.Write("|" + C[i, j] + "|");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Матрица А:");
MatrixFill(A);
Console.WriteLine("Матрица В:");
MatrixFill(B);

Console.WriteLine("Результат сложения матриц:");
Sum(A, B);
Console.WriteLine("Результат вычитания матриц:");
Console.WriteLine("A - B");
Raz(A, B);
Console.WriteLine("B - A");
Raz(B, A);
