#include<stdlib.h>
#include<stdio.h>
#include<string.h>
#include<locale.h>
#include<windows.h>

int main(){
	// Validar senha
	setlocale(LC_ALL, "portuguese");
	char senha[30];
	
	do{
		printf("Entre com a senha: ");
		gets(senha);
		if (strlen(senha) < 7){
			printf("Senha invalida.");
			Sleep(1000);
			system("cls");
		}		
	}while (strlen(senha) < 7);
	
	printf("Senha cadastrada com sucesso.");
	system("pause");	
}
