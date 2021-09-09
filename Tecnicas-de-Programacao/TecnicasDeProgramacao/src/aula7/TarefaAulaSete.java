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
        int n1, n2, n3, n4; // declaração das 4 variavies inteiras (nesse caso o ideal pe usar uma variavel com ponto flutuante)
        n1 = 10;
        n2 = 20;
        n3 = 30;
        n4 = 55;
        
        // processamento
        int soma = n1 + n2 + n3 + n4; 
        int media = soma / 4;
        
        // saída
        System.out.println("--SOMA--");
        System.out.println(n1 + " + " + n2 + " + " + n3 + " + " + n4 + " = " + soma);
        System.out.println("--MÉDIA--");
        System.out.println("(" + n1 + " + " + n2 + " + " + n3 + " + " + n4 + ") / 4 " + " = " + media);
    }
}
