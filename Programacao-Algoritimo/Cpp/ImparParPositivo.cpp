#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main() {
	setlocale(LC_ALL, "portuguese");

    int num;
    printf("Digite um n�mero inteiro: ");
    scanf("%i", &num);
    
    if (num == 0) {
        printf("O n�mero � zero.\n");
    } else if (num > 0 && num % 2 == 0) {
        printf("O n�mero %i � positivo e par.\n", num);
    } else if (num > 0 && num % 2 != 0) {
        printf("O n�mero %i � positivo e �mpar.\n", num);
    } else if (num < 0 && num % 2 == 0) {
        printf("O n�mero %i � negativo e par.\n", num);
    } else {
        printf("O n�mero %i � negativo e �mpar.\n", num);
    }

    system("pause");
}
