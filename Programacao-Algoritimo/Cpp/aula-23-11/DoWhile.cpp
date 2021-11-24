#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <windows.h>

int main() {
	setlocale(LC_ALL, "portuguese");
	int entrada, soma = 0;
	
	do{
		printf("Informe um número inteiro: ");
		scanf("%i", &entrada);
		soma += entrada;
		Sleep(2000);
		system("cls");
	}while (soma < 50);
	
	printf("Valor final = % i%\n", soma);
	system("pause");
}
