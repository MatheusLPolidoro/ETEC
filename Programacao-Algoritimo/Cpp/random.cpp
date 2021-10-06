#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
#include<conio.h>
#include <time.h> 
int main(){
	setlocale(LC_ALL, "portuguese");
	int numeroEscolhido, numeroSorteado;
	srand(time(NULL));
	printf("\nUsúario que número de 0 a 10 estou pensando?????? ");
	scanf("%i", &numeroEscolhido);
	numeroSorteado = rand() % 10;
	if (numeroSorteado == numeroEscolhido){
		printf("\nAcertou, mizeraviiii!!!\n");
	} else {
		printf("\nErrrroooooouuuuuu!!! Número certo era %i\n", numeroSorteado);
	}
	system("pause");
	
}
