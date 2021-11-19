package aula15;

import java.util.Scanner;

public class WhileDefinido2 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        //inicialização
        double total = 0, nota; // Armazena a soma das notas digitas
        int contadorNotas = 1;
        
        while (contadorNotas <= 10){
            System.out.printf("Informe a %d ª nota: ", contadorNotas);
            nota = entrada.nextInt();

            if (nota < 0 || nota > 10){
                System.out.printf("NOTA %.2f INVÁLIDA, DIGITE NOVAMENTE...%d", nota);
            }
            else{
                total += nota;
                contadorNotas++;
            }

        }
        double media = total / (contadorNotas - 1);
        System.out.printf("O total acumulado de notas é :%.2f%nA média das %d notas é : %.2f%n", total, contadorNotas -1, media);
    }
}
