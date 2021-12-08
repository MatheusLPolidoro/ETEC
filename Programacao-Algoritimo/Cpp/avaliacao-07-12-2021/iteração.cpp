#include<stdlib.h>
#include<stdio.h>
#include<string.h>
#include<locale.h>

int main(){
	// Iteração em String
	setlocale(LC_ALL, "portuguese");
	char palavra[30];
	
	printf("Entre com uma palavra qualquer: ");
	gets(palavra);
	printf("Palavra recebida.\n%s\n\n", palavra);
	
	for(int i = 0; i < strlen(palavra); i++){
		for(int c = 0; c <= i; c++){
			printf("%c", palavra[c]);
		}
		printf("\n");
	}
	system("pause");	
}
