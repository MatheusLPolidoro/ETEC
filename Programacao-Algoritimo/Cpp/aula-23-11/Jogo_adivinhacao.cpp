#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <windows.h>
#include<conio.h>
#include <time.h>

int main() {
	setlocale(LC_ALL, "portuguese");

	int entrada, numeroSorteado;
	srand(time(NULL));
	numeroSorteado = rand() % 10;
	
	printf("Qual n�mero estou pensando? ");
	scanf("%i", &entrada);
	
	while (entrada != numeroSorteado ){
		printf("ERROOUUUUUU\n");
		Sleep(1000);
		system("cls");
		if (entrada > numeroSorteado){
			printf("O n�mero � menor! ");
		}
		else if(entrada < numeroSorteado){
			printf("O n�mero � maior! ");
		}
		printf("Qual n�mero estou pensando? ");
		scanf("%i", &entrada);
	}
	Sleep(1000);
	system("cls");
	printf("Parab�ns voc� acertou\n");
	system("pause");
}
