#include<stdlib.h>
#include<stdio.h>
#include<string.h>
//#include<locale.h>

int main(){
	char palavra[30];
	int letras, i, cont_a=0, cont_e;
	setlocale(LC_ALL, "portuguese");
	printf("\n informe um texto\n");
	gets(palavra);
	letras=strlen(palavra);
	for(i=0;i<=letras-1;i++){
		if (palavra[i]=='A'|| palavra[i]=='a'){
			cont_a++;
			palavra[i]='@';
		}
		if (palavra[i]=='E'|| palavra[i]=='e'){
			cont_e++;
			palavra[i]='3';
		}
		
	
	}
	
	printf("\n o texto cont�m %i letra(s) A\n", cont_a );
	printf("\n o texto cont�m %i letra(s) E\n", cont_e );
printf("\n texto modificado = %s\n", palavra);
printf("\n");
system("pause");

}


	
