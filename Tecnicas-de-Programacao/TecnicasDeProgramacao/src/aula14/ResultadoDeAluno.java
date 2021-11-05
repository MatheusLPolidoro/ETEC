package aula14;

import java.util.Scanner;

public class ResultadoDeAluno {
    public static void main(String[] args) {
        //Estrutura de decisão switch-case
        Scanner entrada = new Scanner (System.in);
        System.out.print("Informe a nota do aluno. ENTRE 0 E 10: ");
        int nota = entrada.nextInt();
        entrada.close();
        
        // Estrutura de seleção multipla Switch
        switch(nota) {
            case 0:case 1:case 2:case 3: 
                System.out.println("REPROVADO");break;
            case 4:case 5:
                System.out.println("RECUPERAÇÃO");break;
            case 6:case 7:case 8:case 9:case 10:
                System.out.println("APROVADO");break;
            default:
                System.out.println("Informe uma nota valida.");break;
        }
    }
}
