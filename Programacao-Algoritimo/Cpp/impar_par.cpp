#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
int main(){
	setlocale(LC_ALL, "portuguese");
	
	int valor;
	
	printf("Informe um número para saber se ele é par ou ímpar: ");
	scanf("%i", &valor);
	if (valor == 0){
		printf("\nO valor é zero.\n");
	} else if (valor % 2 == 0) {
		printf("\nO valor é par.\n");
	} else {
		printf("\nO valor é ímpar.\n");
	}
	system("pause");
	
}
