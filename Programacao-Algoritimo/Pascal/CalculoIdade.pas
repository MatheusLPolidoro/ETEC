program CalculoIdade;
uses Crt;
Var
AnoNasc, AnoAtual, idade : integer;

begin
   // { Entrada de dados}
   write ('Digite o ano em que você nasceu: ');
   readln (AnoNasc);
   write ('Digite o ano em que estamos: ');
   readln (AnoAtual);


   // {processamento}
   idade := AnoAtual - AnoNasc;

   // { Saida}
   write( 'Sua idade é: ', idade);

end.