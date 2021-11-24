#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <windows.h>

void armazenarVetor(int vetor[5]){
	int i;
	for (i = 0; i < 5; i++){
		printf("Informe o %iª valor: ", i + 1);	
		scanf("%i", &vetor[i]);
	}
}
void somaVetor(int va[5], int vb[5], int vc[5]){
	int i;
	for (i = 0; i < 5; i++){
		vc[i] = va[i] + vb[i];
	}
}
int main(){
	setlocale(LC_ALL, "portuguese");
	int i, va[5], vb[5], vc[5];
	
	//	armazenar os valores nos vetores
	armazenarVetor(va);
	system("cls");
	armazenarVetor(vb);
	system("cls");
	somaVetor(va, vb, vc);
	
	//	exibindo os valores armazenados
	for (i = 0; i < 5; i++){
		printf("%iª calculo: %i + %i = %i\n", i + 1, va[i], vb[i], vc[i]);	
	}
	
	system("pause");
}
