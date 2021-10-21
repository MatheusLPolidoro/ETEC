package aula13;

import java.util.Scanner;

public class ResultadoDeAluno {
    public static void main(String[] args) {
        //Estrutura de decisão aninhada (if/else)
        Scanner entrada = new Scanner (System.in);
        System.out.print("Informe a nota do aluno. ENTRE 0 E 10: ");
        int nota = entrada.nextInt();
        entrada.close();
        
        if (nota >= 0 && nota < 4) {
            System.out.printf("%nREPROVADO.NOTA: %d ABAIXO DO ESPERADO.%n", nota);
        }
        else if (nota > 3 && nota < 6){
            System.out.printf("%nRECUPERAÇÃO.NOTA: %d NÃO É SUFICIENTE.%n", nota);
        }
        else if (nota > 5 && nota < 11){
            System.out.printf("%nAPROVADO.NOTA: %d É SUFICIENTE.%n", nota);
        }
        else {
            System.out.printf("%nNÚMERO: %d INVÁLIDO%n", nota);
        }
    }
}
