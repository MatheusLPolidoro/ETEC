package aula13;

import java.util.Scanner;

public class IfElseAninhado {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        System.out.println("***CLASSIFICAÇÃO FAIXA ETÁRIA***");
        
        System.out.print("Informe uma idade: ");
        int idade = entrada.nextInt();
        entrada.close();
        
        if (idade >= 60){
            System.out.println("IDOSO");
        }
        else if (idade >= 20){
            System.out.println("ADULTO");
        }
        else {
            System.out.println("ADOLECENTE");
        }
  
            
    }
}
