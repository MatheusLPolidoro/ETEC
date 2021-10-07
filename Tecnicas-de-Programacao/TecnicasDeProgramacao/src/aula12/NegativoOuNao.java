package aula12;

import java.util.Scanner;

public class NegativoOuNao {
    public static void main(String[] args) {
        //Estrutura de decisão composta (if/else)
        Scanner entrada = new Scanner (System.in);
        System.out.print("Informe um número inteiro qualquer: ");
        int num = entrada.nextInt();
        entrada.close();
        
        if (num >= 0) {
            System.out.printf("%nO NÚMERO: %d NÃO É NEGATIVO%n", num);
        }
        else {
            System.out.printf("%nNÚMERO: %d NEGATIVO%n", num);
        }
    }
}
