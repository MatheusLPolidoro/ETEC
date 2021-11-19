package aula15;

public class OperadoresAtribuicaoCompostos {

    public static void main(String[] args) {
        int c, d, e, f, g;
        c = 3;
        d = 5;
        e = 4;
        f = 6;
        g = 12;
        
        // c = c + 7;
        c += 7;
        System.out.println(c);
        
        //d = d - 4;
        d -= 4;
        System.out.println(d);
        
        //e = e * 5;
        e *= 5;
        System.out.println(e);
        
        //f = f / 3;
        f /= 3;
        System.out.println(f);
        
        //g = g % 9;
        g %= 9;
        System.out.println(g);
    }
}
