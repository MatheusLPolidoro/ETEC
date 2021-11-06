package fatorial;

import java.util.Scanner;

public class Fatorial {

    public static void main(String[] args) {
        // Definição de variáveis
        int num, resultado, contador;
        
        // Criação da instancia da classe scanner
        Scanner entrada = new Scanner(System.in);
        
        // Questionamento
        System.out.print("Qual número inteiro você quer saber o fatorial? ");
        
        // Definição e leitura da variável
        num = entrada.nextInt();
        resultado = num;
        
        // Fechar a variável instacia da classe scanner
        entrada.close();
        
        for (contador = num - 1; contador > 0; contador --) {
            resultado *= contador;
        }
        
        // Saída de dados
        System.out.printf("O resultado do fatorial de %d é igual à %d.%n", num, resultado);
    }
    
}
