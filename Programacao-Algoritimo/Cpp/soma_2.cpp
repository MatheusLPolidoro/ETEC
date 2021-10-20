#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
int main(){
	setlocale(LC_ALL, "Portuguese");
	float total, num;
	int index;

	for (index = 1; index <= 5 ; index ++){
		printf("\nDigite o %i � valor: ", index);
		scanf("%f", &num);
		total = total + num;	
	}
	
	printf("\nA soma � igual a %.2f\n", total);
	
	system("pause");
}

