#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <windows.h>

int main() {
	setlocale(LC_ALL, "portuguese");
	int entrada, soma = 0, i;
	
	printf("Informe um número inteiro: ");
	scanf("%i", &soma);
	
	for (i = 1; soma < 50; i++){
		printf("Informe um número inteiro: ");
		scanf("%i", &entrada);
		soma += entrada;
		Sleep(2000);
		system("cls");
	}
	
	printf("Valor final = % i%\n", soma);
	system("pause");
}
