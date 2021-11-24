#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main() {
	setlocale(LC_ALL, "portuguese");
	int i = 1, entrada, soma = 0;
	printf("Informe um número inteiro: ");
	scanf("%i", &entrada);
	
	while (i <= entrada){
//		printf("%i\n", i);
		soma += i;
		i++;
	}
	printf("A soma do número digitado é igual %i\n", soma);
	system("pause");
}
