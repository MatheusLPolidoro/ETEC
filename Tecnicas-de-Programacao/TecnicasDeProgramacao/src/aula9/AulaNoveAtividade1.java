/*
 * Crie um programa que calcule a área do retângulo abaixo e apresente
 * o resultado na tela
 */
package aula9;

import java.util.Scanner;

public class AulaNoveAtividade1 {
    public static void main(String[] args) {

	// Atividade 1-Lendo dados informados pelo usuário

        // declaração de variáveis
        int altura, base, area; 

        // Criação e instância do objeto
        Scanner entrada = new Scanner(System.in);

        // entrada de dados (atribuição de valores para as variáveis)
        System.out.print("Informe a altura do retangulo: ");
        altura = entrada.nextInt();
        System.out.print("Informe a base do retangulo: ");
        base = entrada.nextInt();
        
        // processamento de dados
        area = base * altura;
        
        // saída de dados
        System.out.println("A área do retângulo é de: " + area);
    }
}
