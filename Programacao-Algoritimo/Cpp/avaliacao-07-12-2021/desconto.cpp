#include<stdlib.h>
#include<stdio.h>
#include<string.h>
#include<locale.h>

int main(){
	// Desconto em porcentagem
	setlocale(LC_ALL, "portuguese");
	float salario, con_metros_cubicos, des_con_metros_cubicos;
	
	printf("Informe o valor do salário: ");
	scanf("%f", &salario);
	
	printf("Informe o consumo de metros cubicos de água: ");
	scanf("%f", &con_metros_cubicos);

	if (salario < 1000 && con_metros_cubicos < 10){
		des_con_metros_cubicos = con_metros_cubicos * 0.85;
		printf("Conforme valores informados, você terá 15%% de desconto.\n");
	}
	else {
		des_con_metros_cubicos = con_metros_cubicos * 0.95;
		printf("Conforme valores informados, você terá 5%% de desconto.");
	}		
	
	printf("De %.2f metros cúbicos consumidos, você pagara por %.2f.\n", con_metros_cubicos, des_con_metros_cubicos);
	system("pause");
}
