/*
Desenvolva uma calculadora em linguagem C,
O programa deve contar com todas as operações básicas ( + - * /).
A precisão da calculadora dever ser de dois dígitos.
O programa deve perguntar ao usuário qual operação ele deseja realizar
O programa deve executar quantas vezes  for necessário.
 */
#include<stdio.h>
int main(void){
 float x=0, y=0, resultado=0;
 int op=0;
 do{
  printf("\n\t1 - SOMA \n\t2 - SUBTRACAO\n\t3 - DIVISAO \n\t4 - MULTIPLICACAO\n");
  scanf("%i", &op);
  printf("\nDigite o primeiro numero: ");
  scanf("%f", &x);
  printf("\nDigite o segundo numero: ");
  scanf("%f", &y);
  switch(op){
    case 1:
     resultado=x+y;
     break;
    case 2:
     resultado=x-y;
     break;
    case 3:
     resultado=x/y;
     break;
    case 4:
     resultado=x*y;
     break;
    default:
     printf("\nDigite uma opcao valida\n");
  }
  printf("\n\tO resultado e: %0.2f", resultado);
  printf("\nDigite 1 para continuar: ");
  scanf("%i", &op);
 }while(op==1);
}