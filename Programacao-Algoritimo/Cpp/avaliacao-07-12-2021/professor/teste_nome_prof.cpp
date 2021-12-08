#include<stdlib.h>
#include<stdio.h>
#include<string.h>
#include<locale.h>

int main(){
	char nome[30];
	int letras, i;
	setlocale(LC_ALL, "portuguese");
	printf("\n informe seu nome\n");
	gets(nome);
	letras=strlen(nome);
	printf("\n o nome informado = %s\n", nome);
	printf("\n seu nome tem %i caracteres \n", letras ); 
	printf("\n A primeira letra do seu nome = %c\n", nome[0]);
	printf("\n A segunda letra do seu nome = %c\n", nome[1]);
	printf("\n A terceira letra do seu nome = %c\n", nome[2]);
	printf("\n A última letra do seu nome = %c\n", nome[letras-1]);
    //exibir nome espaçado
	for(i=0;i<=letras-1;i++){
    	printf("%c ",nome[i]);
	}
	//nome na vertical   
	for(i=0;i<=letras-1;i++){
    	printf("\n%c ",nome[i]);
	}
	printf("\n");
	for(i=letras-1;i>=0;i--){
    	printf("%c ",nome[i]);
	}
	
	printf("\n");
	system("pause");
	
	
}
