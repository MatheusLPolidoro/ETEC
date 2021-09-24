package aula10;

import java.util.Locale;
import java.util.Scanner;

/**
 *
 * @author Matheus Polidoro
 * @date 09-23-2021
 * 
 * Construa um programa que permita a entrada 
 * de dados pelo usuário e realiza a saída de dados 
 * sendo que os dados a serem informados são os
 * seus, devendo ser o seu nome real  e os demais dados 
 * podem ser fictícios.
 */

public class TarefaAula10 {
    public static void main(String[] args) {
        // Definição do padrão US de entrada para números flutuantes
        Locale.setDefault(Locale.US);
        
        // Instancia da classe Scanner para entrada de dados
        Scanner entrada = new Scanner(System.in);
        
        // Entrada de tipos de dados do usúario
        System.out.print("Informe o seu nome: ");
        String nome = entrada.nextLine(); // Leitura de uma linha inteira
        
        System.out.print("Informe o estado civil S / C / D / Outros: ");
        char estadoCivil = entrada.next().charAt(0); // Leitura de apenas um caracter, nesse caso o índice "0"
        
        System.out.print("Informe sua altura: ");
        Double altura = entrada.nextDouble(); // Leitura de um valor real
        
        System.out.print("Informe sua idade: ");
        byte idade = entrada.nextByte(); // Leitura de um valor inteiro
        
        System.out.print("Qual o seu salário ? ");
        float salario = entrada.nextFloat(); // Leitura de um valor real
        
        entrada.close(); // Fechar a entrada de dados
        
        // Saída de dados
        System.out.println("*********Dados do usúario*********");
        System.out.printf("Nome: %S %n", nome);
        System.out.printf("Estado Civil: %c %n", estadoCivil);
        System.out.printf("Altura: %.2f %n", altura);
        System.out.printf("Idade: %d %n", idade);
        System.out.printf("Salário: %.2f %n", salario);
    }
}
