#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
int main(){
	setlocale(LC_ALL, "portuguese");
	float n, quadrado;
	
	printf("\nInforme um n�mero para saber o valor de seu quadrado: ");
	scanf("%f", &n);
	
	quadrado = n * n;
	
	printf("\nO quadrado de %.2f � igual � %.2f\n", n, quadrado);
	system("pause");
}
