#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main() {
	setlocale(LC_ALL, "portuguese");

    float valorTenis, valorComDesconto;
    printf("Informe o valor do par de tênis: ");
    scanf("%f", &valorTenis);
    
    if (valorTenis > 500) {
        valorComDesconto = valorTenis - 0.15 * valorTenis;
        printf("O valor total do tênis é de %.2f, com o desconto de 15%% ficou: %.2f\n", valorTenis, valorComDesconto);
    } else {
        valorComDesconto = valorTenis - 0.05 * valorTenis;
        printf("O valor total do tênis é de %.2f, com o desconto de 5%% ficou: %.2f\n", valorTenis, valorComDesconto);
    }

    system("pause");
}
