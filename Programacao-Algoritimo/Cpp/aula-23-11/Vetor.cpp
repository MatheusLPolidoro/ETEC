#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <windows.h>

int main() {
	setlocale(LC_ALL, "portuguese");
	int v[5] = {10, 20, 30, 40, 50}, i;
	
//	exibindo os valores armazenados
	for (i = 0; i < 5; i++){
		printf("%i� valor do vetor = %i\n", i + 1, v[i]);	
	}
	
	system("pause");
}

