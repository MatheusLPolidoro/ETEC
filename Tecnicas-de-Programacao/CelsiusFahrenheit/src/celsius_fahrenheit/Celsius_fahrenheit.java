package celsius_fahrenheit;

import java.util.Scanner;

/**
 *
 * @author mattp
 */
public class Celsius_fahrenheit {

    public static void main(String[] args) {
        // Variáveis
        float c, f;
        
        // Criação de instancia do objeto de entrada,
        Scanner entrada = new Scanner(System.in);
        
        // Apresentação
        System.out.println("\n\t\t\t -- Converter celsius para fahrenheit");
        
        // Entrada
        System.out.print("Informe a temperatura em celsius: ");
        c = entrada.nextFloat();
        
        // Processamento
        f = 9 * c / 5 + 32;
        
        // Saída
        System.out.printf("\n\t C° %f F° %f \n", c, f);
        
        
    }
    
}
