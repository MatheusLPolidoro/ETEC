#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
int main(){
	setlocale(LC_ALL, "portuguese");
	
	int valor;
	
	printf("Informe um n�mero para saber se ele � par ou �mpar: ");
	scanf("%i", &valor);
	if (valor == 0){
		printf("\nO valor � zero.\n");
	} else if (valor % 2 == 0) {
		printf("\nO valor � par.\n");
	} else {
		printf("\nO valor � �mpar.\n");
	}
	system("pause");
	
}
