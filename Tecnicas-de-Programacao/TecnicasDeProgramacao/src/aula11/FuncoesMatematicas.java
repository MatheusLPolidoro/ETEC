package aula11;

/**
 *
 * @author mattp
 * @date 09-30-2021
 */
public class FuncoesMatematicas {
    public static void main(String[] args) {
        // método sqrt
        int a;
        double resultadoRaizQuadrada;
        
        // entrada de dados
        a = 4;
        
        // processamento de dados
        resultadoRaizQuadrada = Math.sqrt(a);
        
        // saída de dados
        System.out.println(resultadoRaizQuadrada);
        
        // método pow
        int b, c;
        double resultadoPotencia;
        
        // entrada de dados
        b = 10;
        c = 3;
        
        // processamento de dados
        resultadoPotencia = Math.pow(b, c);
        
        // saída de dados
        System.out.println(resultadoPotencia);
        
        // método random
        int d;
        
        // processamento de dados
        d = (int)(Math.random() * 10);
        
        // saída de dados
        System.out.println(d);
    }
}
