#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
int main(){
	setlocale(LC_ALL, "portuguese");
	float horasPorDia, salario;
	
	printf("Informe quantas horas por dia voc� trabalha: ");
	scanf("%f", &horasPorDia);
	
	salario = 50.00 * horasPorDia* 30;
	
	printf("\nO seu sal�rio � de %.2f\n", salario);
	
	system("pause");
	
}
