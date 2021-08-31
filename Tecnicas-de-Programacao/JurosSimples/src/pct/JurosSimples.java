package pct;
import java.util.Scanner;
public class JurosSimples {
    public static void main(String[] args) {
        double CapIni, Taxa, Juros, CapFin;
        int Tempo;
        System.out.println("\n\t\t\t -- Calculadora de Juros -- \n");
        // Entrada de dados
        Scanner entrada = new Scanner(System.in);
        System.out.println("Quanto você vai investir: ");
        CapIni = entrada.nextDouble();
        System.out.println("Qual será valor da taxa: ");
        Taxa = entrada.nextDouble();
        System.out.println("Quanto tempo vai ficar o investimento: ");
        Tempo = entrada.nextInt();
        
        // Processamento de dados
        Juros = 100 / Taxa * CapIni * Tempo;
        CapFin = CapIni + Juros;
        
        // Saida de dados
        System.out.printf("O total de juros é de: R$%.2f \n", Juros);
        System.out.printf("Você resgatara um valor total de: R$%.2f \n", CapFin);
    }
}
