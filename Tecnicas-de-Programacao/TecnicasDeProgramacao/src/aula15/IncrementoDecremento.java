package aula15;

public class IncrementoDecremento {
    public static void main(String[] args) {
        
        int i = 10;
        
        // pós incremento
        System.out.println(i++); //aqui avalia a expressão antes do incremento i = 10
        System.out.println(i); // aqui o i passa a valer 11
        
        // pós decremento
        System.out.println(i--); //aqui avalia a expressão antes do decremento i = 11
        System.out.println(i); // aqui o i passa a valer 10
        
        
    }
}
