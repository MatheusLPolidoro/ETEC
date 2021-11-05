package aula14;

import java.util.Scanner;

public class DescontoOperadorTernario {

    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        System.out.print("Infome o valor da compra :");
        double valorCompra = entrada.nextDouble();
        
        double desconto = valorCompra > 50 ? valorCompra * 0.1 : valorCompra * 0.05;
        
        System.out.printf("Compra de R$ %.2f e desconto de R$ %.2f%n", valorCompra, desconto);
        entrada.close();
    }
}
