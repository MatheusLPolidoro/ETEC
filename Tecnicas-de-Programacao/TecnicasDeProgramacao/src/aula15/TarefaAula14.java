package aula15;

import java.util.Scanner;

public class TarefaAula14 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        System.out.print("Informe a nota do aulo entre 0 e 10: ");
        int nota = entrada.nextInt();
        entrada.close();
        
        switch(nota){
            case 10: case 9: case 8: case 7: case 6:
                System.out.println("APROVADO");break;
            case 5: case 4:
                System.out.println("RECUPERAÇÃO");break;
            case 3: case 2: case 1: case 0:
                System.out.println("REPROVADO");break;
            default:
                System.out.println("INSIRA UMA NOTA VÁLIDA");break;
        }
    }
}
