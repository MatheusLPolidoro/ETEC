#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
#include <time.h>
int main(){
	setlocale(LC_ALL, "portuguese");
	struct tm * data;
	time_t segundos;
	
	int anoNasc, anoAtual, idade, diasDeVida;
	
	time(&segundos);
	data = localtime(&segundos);  
	
	anoAtual = data -> tm_year + 1900;
	
	printf("Informe seu ano de nascimento: ");
	scanf("%i", &anoNasc);
	
	idade = anoAtual - anoNasc;
	diasDeVida = 365 * idade;
	
	printf("\nVocê tem %i de idade, são %i dias.\n", idade, diasDeVida);
	
	system("pause");
}
