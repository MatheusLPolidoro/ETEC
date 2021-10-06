#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
int main(){
	setlocale(LC_ALL, "Portuguese");	
	float total, num, media;
	int index;
	
	for (index = 1; index <= 4 ; index ++){
		printf("\nDigite o %i ° valor: ", index);
		scanf("%f", &num);
		total = total + num;	
	}
		
	media = total / (index - 1);
	printf("\nA média é igual a %.2f\n", media);
	system("pause");
}

