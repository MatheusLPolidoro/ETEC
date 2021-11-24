#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <windows.h>

int main() {
	setlocale(LC_ALL, "portuguese");
	int i = 1;
	
	do{
		printf("%i\n", i);
		i++;		
	}while (i <= 10);
	
	system("pause");
}
