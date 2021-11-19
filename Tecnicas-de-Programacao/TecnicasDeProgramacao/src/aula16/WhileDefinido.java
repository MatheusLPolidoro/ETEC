package aula15;
// programa para fazer a contagem regressiva apartir de 5
public class WhileDefinido {
    public static void main(String[] args) {
        int contador = 5;
        
        System.out.printf("Contagem regressiva apartir de %d:%n", contador);
        
        //Loop definido
        while (contador >= 0){
            System.out.printf("CONTADOR => %d %n", contador--); //pós decremento
        }
    }
}
