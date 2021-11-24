#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <windows.h>

int main() {
	setlocale(LC_ALL, "portuguese");
	int v[5], i;
//	armazenar os valores no vetor
	for (i = 0; i < 5; i++){
		printf("Informe o %iª valor: ", i + 1);	
		scanf("%i", &v[i]);
	}
		
//	exibindo os valores armazenados
	for (i = 0; i < 5; i++){
		printf("%iª valor do vetor = %i\n", i + 1, v[i]);	
	}
	
	system("pause");
}

