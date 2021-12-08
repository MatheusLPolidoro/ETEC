// inclusão de referências as bibliotecas.
#include<stdio.h>   // biblioteca de entrada e saída de dados (input/ output).
#include<stdlib.h>  // biblioteca padrão do C (funções de controle de memória, processos, conversões e outras).
#include<string.h>  // biblioteca de manipulação de Springs (textos).
#include<locale.h>  // biblioteca de localização, utilizada para modificar padrão de formatos textuais (acentos).
#include<windows.h> // biblioteca de funções da API do Windows, macros comuns do Windows.

int main (){
    setlocale(LC_ALL,"portuguese"); // definir o padrão textual para português.
    char nome[30], nome1[30]; // declarar variáveis (nome, nome1) do tipo char (caractere) como array (vetor) de 30 espaços.
    int letras, i; // definir variáveis (letras, i) do tipo int (números inteiros).
    do{ // inicio do laço de repetição (na primeira volta ele entra sem critério).
        system("cls"); // limpeza do terminal do Windows.
        printf("\nDigite seu nome:\n\a"); // exibe no terminal o texto entre (""), (\n) quebra de linha, (\a) som de alerta.
        gets(nome); // pegar o valor digitado e incluir na variável (nome).
        printf("\nConfirme valor Digitado\n\a");
        gets(nome1);
    // enquanto a condição for VERDADE (True) repetira as instruções entre do{ }while.
    }while((strlen(nome)<6)||(strlen(nome1)<6)); // enquanto (tamanho de nome for menor que 6 OU tamanho de nome1 for menor que 6) REPITA.
    
    // estrutura condicional.
    // strcmp compara o valor das strings e devolve um inteiro = 1(1ª texto maior), -1(2ª texto maior) ou 0(textos iguais).
    if(!strcmp(nome,nome1)){ // SE NÃO ("!" é uma negação) strcmp for 0 (false) o valor vira (true).
        printf("\n valores iguais\n");
    }else{
        printf("\n valores diferentes\n");
    }
    system("pause"); // aguarda que o usuário digite qualquer tecla para encerrar o programa e sair do terminal.
}
