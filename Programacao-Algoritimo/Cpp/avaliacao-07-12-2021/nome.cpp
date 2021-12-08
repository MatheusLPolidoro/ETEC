// inclus�o de refer�ncias as bibliotecas.
#include<stdio.h>   // biblioteca de entrada e sa�da de dados (input/ output).
#include<stdlib.h>  // biblioteca padr�o do C (fun��es de controle de mem�ria, processos, convers�es e outras).
#include<string.h>  // biblioteca de manipula��o de Springs (textos).
#include<locale.h>  // biblioteca de localiza��o, utilizada para modificar padr�o de formatos textuais (acentos).
#include<windows.h> // biblioteca de fun��es da API do Windows, macros comuns do Windows.

int main (){
    setlocale(LC_ALL,"portuguese"); // definir o padr�o textual para portugu�s.
    char nome[30], nome1[30]; // declarar vari�veis (nome, nome1) do tipo char (caractere) como array (vetor) de 30 espa�os.
    int letras, i; // definir vari�veis (letras, i) do tipo int (n�meros inteiros).
    do{ // inicio do la�o de repeti��o (na primeira volta ele entra sem crit�rio).
        system("cls"); // limpeza do terminal do Windows.
        printf("\nDigite seu nome:\n\a"); // exibe no terminal o texto entre (""), (\n) quebra de linha, (\a) som de alerta.
        gets(nome); // pegar o valor digitado e incluir na vari�vel (nome).
        printf("\nConfirme valor Digitado\n\a");
        gets(nome1);
    // enquanto a condi��o for VERDADE (True) repetira as instru��es entre do{ }while.
    }while((strlen(nome)<6)||(strlen(nome1)<6)); // enquanto (tamanho de nome for menor que 6 OU tamanho de nome1 for menor que 6) REPITA.
    
    // estrutura condicional.
    // strcmp compara o valor das strings e devolve um inteiro = 1(1� texto maior), -1(2� texto maior) ou 0(textos iguais).
    if(!strcmp(nome,nome1)){ // SE N�O ("!" � uma nega��o) strcmp for 0 (false) o valor vira (true).
        printf("\n valores iguais\n");
    }else{
        printf("\n valores diferentes\n");
    }
    system("pause"); // aguarda que o usu�rio digite qualquer tecla para encerrar o programa e sair do terminal.
}
