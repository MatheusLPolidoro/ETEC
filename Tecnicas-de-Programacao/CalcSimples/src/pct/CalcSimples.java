package pct;

import java.util.Scanner;

/**
 *
 * @author mattp
 */
public class CalcSimples {

    public static void main(String[] args) {
        // Declaração de Variáveis
        int n1, n2, total;
        
        // Criação de instancia do objeto de entrada
        Scanner entrada = new Scanner(System.in);
        
        // Apresentação
        System.out.println("\n\t\t\t -- Calculadora Simples -- \n");
        
        // Entradas
        System.out.print("Informe o primeiro número: ");
        n1 = entrada.nextInt();
        System.out.print("Informe o segundo número: ");
        n2 = entrada.nextInt();
        
        // Processamento
        total = n1 + n2;
        
        //Saída
        // System.out.println("\n\t" + n1 + " + " + n2 + " = " + total + "\n");
        System.out.printf("\n\t %d + %d = %d \n", n1, n2, total);
    }
    
}
