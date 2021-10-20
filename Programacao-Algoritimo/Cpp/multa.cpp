#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main() {
	setlocale(LC_ALL, "portuguese");
	
	float velocidade;
    printf("A velocidade do carro capturada pelo radar é: ");
    scanf("%f", &velocidade);
    
    if (velocidade > 120) {
    	printf("Carro multado! Velocidade de %.2f superior a 120 Km/h\n", velocidade);
	} else if (velocidade > 0){
		printf("Carro liberado... Velocidade de %.2f dentro de 120 Km/h\n", velocidade);
	} else {
		printf("Velocidade invalida capturada!\n");
	}
	
	system("pause");
}
