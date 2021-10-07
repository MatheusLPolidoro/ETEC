package aula12;

import java.util.Locale;
import java.util.Scanner;

public class InstrucaoIf {
    public static void main(String[] args) {
        
        Scanner entrada = new Scanner (System.in);
        Locale.setDefault(Locale.US);
        System.out.print("Entre com o valor da sua nota: ");
        double nota = entrada.nextDouble();
        entrada.close();
        
        if (nota >= 6) {
            System.out.printf("%nPARABÉNS NOTA: %.2f VOCÊ FOI APROVADO%n", nota);
        }
        else {
            System.out.printf("%nVOCÊ FOI REPROVADO, NOTA: %.2f%n", nota);
        }
    }
}
