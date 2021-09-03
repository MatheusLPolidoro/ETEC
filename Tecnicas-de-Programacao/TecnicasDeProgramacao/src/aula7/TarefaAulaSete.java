// Atividade da aula 7
/*
 * •	Declarar 4 variáveis numéricas do tipo inteiro (int);
 * •	Inicializá-las com algum valor;
 * •	Obter a soma destas variáveis;
 * •	Obter a média destas variáveis;
 * •	Imprimir esses resultados na tela.
 */
package aula7;

public class TarefaAulaSete {
    public static void main(String[] args) {
        // Inicio do programa
        int n1, n2, n3, n4, soma, media; // declaração
        n1 = 10;
        n2 = 8;
        n3 = 9;
        n4 = 7;
        
        // processamento
        soma = n1 + n2 + n3 + n4; 
        media = soma / 4;
        
        // saída
        System.out.println("--SOMA--");
        System.out.println(n1 + " + " + n2 + " + " + n3 + " + " + n4 + " = " + soma);
        System.out.println("--MÉDIA--");
        System.out.println("(" + n1 + " + " + n2 + " + " + n3 + " + " + n4 + ") / 4 " + " = " + media);
    }
}
