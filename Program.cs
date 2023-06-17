//declaramos la matriz
int[,] matriz = new int[3, 2];

//intentamos asignar valores a los elemntos de la matriz
matriz[0, 0] = 1;
matriz[0, 1] = 2;
matriz[1, 0] = 3;
matriz[1, 1] = 4;
matriz[2, 0] = 5;
matriz[2, 1] = 6;

//intentamos imrimir los valores de la matriz
for (int i = 0; i < 3; i++)
{
 // el erro es por el cambio de i x j  de manera que no realiza los valores que se requeiren
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine("elemneto en la posicion [{0}, {1}]: {2}", i, j, matriz[i, j]);
    }

}
Console.ReadLine();