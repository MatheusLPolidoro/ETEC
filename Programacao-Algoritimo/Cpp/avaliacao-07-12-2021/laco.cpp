#include<stdlib.h>
#include<stdio.h>
#include<string.h>
#include<locale.h>

int main(){
	// La�o de repeti��o
	setlocale(LC_ALL, "portuguese")

	for(int i = 1; i <= 40; i++){
		if (i % 5 != 0){
			printf("%i.", i);
		}
		else{
			printf("PAM\n");	
		}
	}
	system("pause");	
}
