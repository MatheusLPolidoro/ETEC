#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
#include<windows.h>
int main(){
setlocale(LC_ALL,"portuguese");
// receber um valor do usu�rio e informar se � par ou impar
int num;
printf("\n Informe um valor num�rico\n");
scanf("%i",&num);
if (num%2==0){
system("color 2");
printf("\n o numero %i � par\n", num);
Sleep(2000);
Beep(5000,1000);
}
else
{
system("color 4");
printf("\n o numero %i � �mpar\n",num);
Beep(2000,1000);
Sleep(2000);
}
return(0);
}
