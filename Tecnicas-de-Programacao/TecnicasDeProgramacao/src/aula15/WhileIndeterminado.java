package aula15;

import java.util.Scanner;

public class WhileIndeterminado {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
        //fase inicialização
        double somaDasNotas = 0;
        double nota = 0;
        int contadorNotas = 0;
        
        //loop laço de repetição
        while (nota != -1){
            System.out.print("Digite uma nota entre 0 e 10 ou digite -1 para ENCERRAR: ");
            nota = entrada.nextDouble();
            
            if (nota <= 10 && nota >= 0){
                somaDasNotas += nota;
                contadorNotas++;
            }
            else if (nota != -1){
                System.out.println("NOTA INVÁLIDA!!");
            }
        }
        entrada.close();
        System.out.printf("A média é: %.2f%n", somaDasNotas / contadorNotas);
    }
}
