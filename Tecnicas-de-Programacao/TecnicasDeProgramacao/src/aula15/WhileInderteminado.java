package aula15;

import java.util.Scanner;

public class WhileInderteminado {

    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        //fase inicialização
        double somaDasNotas = 0; // armazena a soma das notas digitadas
        double nota = 0; // armazena o valor da nota que o usúario digitar
        int contadorNotas = 0; // contador de notas
        
        // loop laço de repetição
        while (nota != -1){
            System.out.print("Digite uma nota válida entre 0 e 10: ");
            nota = entrada.nextDouble();
            somaDasNotas += (nota >= 0 && nota <= 10) ?  nota : 0;           
        }
        System.out.printf("O valor soma das notas é: %.2f%n",somaDasNotas);
        entrada.close();
    }
}
