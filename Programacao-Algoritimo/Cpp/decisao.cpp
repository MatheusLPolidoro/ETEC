#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
int main(){
	setlocale(LC_ALL, "portuguese");
	int x;
	
	printf("Informe um valor inteiro: ");
	scanf("%i", &x);
	
	if ((x > 10) && (x < 50)){
		system("color 3");
		printf("\nO valor %i está dentro da faixa.\n", x);
	} else {
		system("color 4");
		printf("\nO valor %i está fora da faixa.\n", x);
	}
	
	system("pause");
	
}
