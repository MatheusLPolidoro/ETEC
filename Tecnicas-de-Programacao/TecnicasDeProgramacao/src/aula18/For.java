
package aula18;

import java.util.Scanner;

public class For {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        System.out.print("Informe quantos números deseja somar: ");
        int quantidadeNumeros = entrada.nextInt();
        
        
        double conta = 0;
        
        for (int i=1; i <= quantidadeNumeros; i++){
            System.out.printf("Informe o %d número: ", i);
            conta = conta + entrada.nextDouble();
        }
        
        System.out.printf("A soma dos números informados é: %.2f%n",conta);
        entrada.close();
    }
}
