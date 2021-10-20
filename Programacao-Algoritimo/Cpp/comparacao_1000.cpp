#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main() {
	setlocale(LC_ALL, "portuguese");

    int num;
    printf("Digite um número inteiro: ");
    scanf("%i", &num);
    
    if (num == 1000) {
        printf("O número é 1000.\n");
    } else if (num > 1000) {
        printf("O número %i é maior do que 1000.\n", num);
    } else {
        printf("O número %i é menor do que 1000.\n", num);
    }

    system("pause");
}
