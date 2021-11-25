#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <windows.h>

void armazenarVetor(int vetor[5]){
	for (int i = 0; i < 5; i++){
		printf("Informe o %iª valor: ", i + 1);	
		scanf("%i", &vetor[i]);
	}
	system("cls");
}
void somaVetor(int va[5], int vb[5], int vc[5]){
	for (int i = 0; i < 5; i++){
		vc[i] = va[i] + vb[i];
	}
}
void mostrarVetor(int va[5], int vb[5], int vc[5]){
	for (int i = 0; i < 5; i++){
		printf("%iª calculo: %i + %i = %i\n", i + 1, va[i], vb[i], vc[i]);	
	}
}
int main(){
	setlocale(LC_ALL, "portuguese");
	int i, va[5], vb[5], vc[5];
	
	//	armazenar os valores nos vetores
	armazenarVetor(va);
	armazenarVetor(vb);
	somaVetor(va, vb, vc);
	
	//	exibindo os valores armazenados
	mostrarVetor(va, vb, vc);
	
	system("pause");
}
