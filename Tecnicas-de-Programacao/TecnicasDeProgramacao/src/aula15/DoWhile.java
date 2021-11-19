/*Programa que recebe 10 valores inteiros e após receber estes valores mostre na 
tela qual foi o maior número digitado .*/

package aula15;

import java.util.Scanner;

public class DoWhile {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        //inicialização
        int valor, maiorValor = 0, contador = 1;
        
        //loop laço de repetição
        do{
            System.out.printf("informe o %dª valor inteiro qualquer: ", contador);
            valor = entrada.nextInt();
            
            if (valor > maiorValor){
                maiorValor = valor;
            }
            
            contador++;
            
        }while(contador <= 10);
        entrada.close();

        System.out.printf("Entre os %d valores, o maior valor digitado foi: %d", --contador, maiorValor);
    }
}
