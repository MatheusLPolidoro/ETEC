#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
int main(){
	float n, dobro;
	setlocale(LC_ALL, "portuguese");
	
	printf("\nInforme um n�mero\n");
	scanf("%f", &n);
	
	dobro = n * 2;
	
	printf("\nO %.2f multiplicado por dois � igual � %.2f\n", n, dobro);
	system("pause");
}
