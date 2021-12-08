#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
#include<conio.h>
#include <time.h> 

int main(){
	// Sorteio de números aleatórios
	setlocale(LC_ALL, "portuguese");
	int numero_escolhido, qtd_acerto, numero_sorteado[5];
	srand(time(NULL));

	printf("\nEntre com seu número da sorte para saber quantas vezes ele será sorteado: ");
	scanf("%i", &numero_escolhido);
	
	for(int i = 0; i < 5; i++){
		numero_sorteado[i] = rand() % 60;	
		if (numero_sorteado[i] == numero_escolhido){
			qtd_acerto++;
		}
	}
	printf("Os números sorteados foram: ");
	for(int i = 0; i < 5; i++){
		printf("%i, ", numero_sorteado[i]);
	}
	
	if (qtd_acerto != 1){
		printf("\nSeu numero: %i foi sorteado %i vezes.\n", numero_escolhido, qtd_acerto);	
	}
	else{
		printf("\nSeu numero: %i foi sorteado %i vez.\n", numero_escolhido, qtd_acerto);
	}
	system("pause");
}
