package aula11;

import java.util.Locale;
import java.util.Scanner;

/**
 *
 * @author mattp
 * @date 09-30-2021
 */
public class VolumeCubo {
    public static void main(String[] args) {
        // Definição do padrão US de entrada para números flutuantes
        Locale.setDefault(Locale.US);
        
        // Atividade 1-Calculo de volume de um cubo com método pow da Classe Math
        double volume, aresta;
        
        // instancia da classe Scanner
        Scanner entrada = new Scanner(System.in);
        
        // entrada de dados
        System.out.println("\t\t------Calculo do volume do cubo------");
        System.out.print("Informe o valor da aresta do cubo: ");
        aresta = entrada.nextDouble();
        
        entrada.close(); // fechar a Classe scanner
        
        // processamento de dados
        volume = Math.pow(aresta, 3);
        
        // saída de dados
        System.out.printf("%nO volume do cubo é de %.2f.%n", volume);
        
    }
}
