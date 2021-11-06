/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pct;

import java.util.Scanner;

/**
 *
 * @author Samsung-ingrid
 */
public class CalcJuros {
    public static void main(String[] args) {
        //VÁRIAVEIS
        double valor, taxa, tempo, juros;
        String escolhaUpper;
        
        do {
            //apresentação
            System.out.println("\n\t\t\t --Calculadora de Juros --\t");
            //Criação instancia de entrada de dados
            Scanner entrada = new Scanner(System.in);
            //Dados
            System.out.print("Digite o valor: ");
            valor = entrada.nextDouble();
            System.out.print("Digite é a taxa: ");
            taxa = entrada.nextDouble();
            System.out.print("Digite o tempo tempo para pagar: ");
            tempo = entrada.nextDouble();
            //Soma/Formula
            juros = valor * taxa * tempo/100;
            //Saida de dados
            System.out.printf("Seu juros é de R$: %.2f%nCapital total final de "
                    + "R$: %.2f%n%n", juros, valor + juros);
            
            // Verificar se deve continuar ou não
            do {
                System.out.print("Deseja realizar um novo calculo? [S/N]: ");
                escolhaUpper = entrada.nextLine().toUpperCase();
                System.out.println(escolhaUpper);
            } while (!(escolhaUpper.equals("S")) && !(escolhaUpper.equals("N")));
            
        } while (escolhaUpper.equals("S"));
    }
}