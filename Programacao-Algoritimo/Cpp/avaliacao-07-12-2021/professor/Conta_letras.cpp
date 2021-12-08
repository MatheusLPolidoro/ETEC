#include<stdlib.h>
#include<stdio.h>
#include<string.h>
#include<locale.h>

int main(){
	char palavra[30];
	int letras, i, cont_a=0;
	setlocale(LC_ALL, "portuguese");
	printf("\n informe um texto\n");
	gets(palavra);
	letras=strlen(palavra);
	for(i=0;i<=letras-1;i++){
		if (palavra[i]=='A'|| palavra[i]=='a'){
			cont_a++;
		}
	
	}
	printf("\n o texto contém %i letra(s) A\n", cont_a );
printf("\n");
system("pause");

}


	
