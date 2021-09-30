package aula11;

import java.util.Scanner;

/**
 *
 * @author Matheus Polidoro
 * @date 09-30-2021
 * 
 */

public class ProcessamentoCasting {
    public static void main(String[] args) {
        // Instancia da classe Scanner para entrada de dados
        Scanner entrada = new Scanner(System.in);
        
        int n1,n2,n3,n4;
        double media;
        
        // Entrada de tipos de dados do usúario
        System.out.print("Informe a primeira nota: ");
        n1 = entrada.nextInt(); // Leitura de um velor inteiro
        
        System.out.print("Informe a segunda nota: ");
        n2 = entrada.nextInt(); // Leitura de um velor inteiro
        
        System.out.print("Informe a terceira nota: ");
        n3 = entrada.nextInt(); // Leitura de um velor inteiro
        
        System.out.print("Informe a quarta nota: ");
        n4 = entrada.nextInt(); // Leitura de um velor inteiro
        
        entrada.close(); // Fechar a Classe Scanner
        
        // Operação de casting, para conversão do tipo de dados
        media = (double)(n1 + n2 + n3 + n4) / 4;
        
        // saída de dados
        System.out.println(media);
    } 
}
