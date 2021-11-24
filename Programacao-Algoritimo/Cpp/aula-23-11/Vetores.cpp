#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <windows.h>

int main() {
	setlocale(LC_ALL, "portuguese");
	int va[5], vb[5], vc[5], i;
	
//	armazenar os valores no vetor
	for (i = 0; i < 5; i++){
		printf("Informe o %iª valor: ", i + 1);	
		scanf("%i", &va[i]);
	}
	for (i = 0; i < 5; i++){
		printf("Informe o %iª valor: ", i + 1);	
		scanf("%i", &vb[i]);
	}
	for (i = 0; i < 5; i++){
		vc[i] = va[i] + vb[i];
	}
		
//	exibindo os valores armazenados
	for (i = 0; i < 5; i++){
		printf("%iª calculo: %i + %i = %i\n", i + 1, va[i], vb[i], vc[i]);	
	}
	system("pause");
}

