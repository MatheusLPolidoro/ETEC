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
	
	printf("Qual número estou pensando? ");
	scanf("%i", &entrada);
	
	while (entrada != numeroSorteado ){
		printf("ERROOUUUUUU\n");
		Sleep(1000);
		system("cls");
		if (entrada > numeroSorteado){
			printf("O número é menor! ");
		}
		else if(entrada < numeroSorteado){
			printf("O número é maior! ");
		}
		printf("Qual número estou pensando? ");
		scanf("%i", &entrada);
	}
	Sleep(1000);
	system("cls");
	printf("Parabéns você acertou\n");
	system("pause");
}
