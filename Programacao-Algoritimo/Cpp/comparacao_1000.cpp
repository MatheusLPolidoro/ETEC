#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main() {
	setlocale(LC_ALL, "portuguese");

    int num;
    printf("Digite um n�mero inteiro: ");
    scanf("%i", &num);
    
    if (num == 1000) {
        printf("O n�mero � 1000.\n");
    } else if (num > 1000) {
        printf("O n�mero %i � maior do que 1000.\n", num);
    } else {
        printf("O n�mero %i � menor do que 1000.\n", num);
    }

    system("pause");
}
