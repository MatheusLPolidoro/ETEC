#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
int main(){
	setlocale(LC_ALL, "portuguese");
	float peso, altura, imc;
	
	printf("Informe sua altura: ");
	scanf("%f", &altura);
	printf("\nInforme seu peso: ");
	scanf("%f", &peso);
	
	imc = peso / (altura * altura);
	
	printf("\nO seu IMC é de %.2f...\n", imc);
	
	if (imc > 25) {
		printf("Você está acima do peso.\n");
	} else {
		printf("Você está com o peso normal.\n");
	}
	
	system("pause");
}
