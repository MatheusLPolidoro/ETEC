#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
int main(){
	float num1, num2, num3, num4, total;
	setlocale(LC_ALL, "Portuguese");
	
	printf("\nDigite o primeiro valor\n");
	scanf("%f", &num1);
	printf("\nDigite o segundo valor\n");
	scanf("%f", &num2);
	printf("\nDigite o terceiro valor\n");
	scanf("%f", &num3);
	printf("\nDigite o quarto valor\n");
	scanf("%f", &num4);
	
	total = num1 + num2 + num3 + num4;
	
	printf("\nA soma é igual a %.2f\n", total);
	
	system("pause");
}

