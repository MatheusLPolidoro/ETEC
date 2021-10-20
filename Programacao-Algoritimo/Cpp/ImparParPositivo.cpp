#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main() {
	setlocale(LC_ALL, "portuguese");

    int num;
    printf("Digite um número inteiro: ");
    scanf("%i", &num);
    
    if (num == 0) {
        printf("O número é zero.\n");
    } else if (num > 0 && num % 2 == 0) {
        printf("O número %i é positivo e par.\n", num);
    } else if (num > 0 && num % 2 != 0) {
        printf("O número %i é positivo e ímpar.\n", num);
    } else if (num < 0 && num % 2 == 0) {
        printf("O número %i é negativo e par.\n", num);
    } else {
        printf("O número %i é negativo e ímpar.\n", num);
    }

    system("pause");
}
