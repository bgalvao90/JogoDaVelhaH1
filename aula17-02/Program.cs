﻿string[,] tabuleiro = new string[3,3];
//matriz
//3x3
//armazenar X , O ou vazio

int linha, coluna;
string jogadorO = "O";
string jogadorX = "X";
string jogadorAtual = jogadorX;

bool fimDeJogo = false;


while (!fimDeJogo)
{
    Console.WriteLine("Jogador atual: "+jogadorAtual);
    Console.WriteLine("Digite a linha:");
    linha = int.Parse(Console.ReadLine())-1;

    Console.WriteLine("Digite a coluna");
    coluna = int.Parse(Console.ReadLine())-1;


    if (tabuleiro[linha, coluna] == null)
    {
        tabuleiro[linha, coluna] = jogadorAtual;
        if (
            (tabuleiro[0,0] == tabuleiro[0,1] && tabuleiro[0,1] == tabuleiro[0,2] && tabuleiro[0, 0] != null) ||
            (tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[1, 2] && tabuleiro[1, 0] != null) ||
            (tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 1] == tabuleiro[2, 2] && tabuleiro[2, 0] != null) 
            )
        {
            Console.WriteLine($"Vitória do jogador {jogadorAtual}");
            break;
        }
        if (jogadorAtual == jogadorX)
            jogadorAtual = jogadorO;


        else

            jogadorAtual = jogadorX;
    }
    else
    {
        Console.WriteLine("Posição está ocupada.");
        
    }
    ImprimirTabuleiro();
}


Console.ReadLine();


void ImprimirTabuleiro()
{
    for (int linhaTabuleiro = 0; linhaTabuleiro < 3; linhaTabuleiro++)
    {
        for( int colunaTabuleiro = 0; colunaTabuleiro < 3; colunaTabuleiro++)
        {
            Console.Write(" " + tabuleiro[linhaTabuleiro,colunaTabuleiro] + " ");
        }
        Console.WriteLine();
    }
}
