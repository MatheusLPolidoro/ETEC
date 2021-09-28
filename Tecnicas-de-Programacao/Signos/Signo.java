import java.util.Scanner;

public class Signo {
    public static void main(String[] args) {
        int dia, mes;
        String msg;

        Scanner entrada = new Scanner(System.in);

        System.out.println("\t\t\t----------- Signos do Zodiaco -----------");

        System.out.print("Informe o dia: ");
        dia = entrada.nextInt();
        System.out.print("Informe o mes: ");
        mes = entrada.nextInt();
        msg = "";
        
        if (mes ==  3 && dia >= 21 || mes ==  4 && dia <= 19 )
            msg = "aries";
        else if (mes == 4 && dia >= 20 || mes == 5 && dia <= 20)
            msg = "touro";
        else if (mes == 5 && dia >= 21 || mes == 6 && dia <= 21)
            msg = "gemeos";
        else if (mes == 6 && dia >= 22 || mes == 7 && dia <= 22)       
            msg = "cancer";
        else if (mes == 7 && dia >= 23 || mes == 8 && dia <= 22)
            msg = "leao";
        else if (mes == 8 && dia >= 23 || mes == 9 && dia <= 22)
            msg = "virgem";
        else if (mes == 9 && dia >= 23 || mes == 10 && dia <= 22)
            msg = "libra";
        else if (mes == 10 && dia >= 23 || mes == 11 && dia <= 21)
            msg = "esc||piao";
        else if (mes == 11 && dia >= 22 || mes == 12 && dia <= 21)
            msg = "sagitario";
        else if (mes == 12 && dia >= 22 || mes == 1 && dia <= 19)
            msg = "capric||nio";
        else if (mes == 1 && dia >= 20 || mes == 2 && dia <= 18)
            msg = "aquario";
        else if (mes == 2 && dia >= 19 || mes == 3 && dia <= 20)
            msg = "peixes";
        

        System.out.print(msg);

    }
}