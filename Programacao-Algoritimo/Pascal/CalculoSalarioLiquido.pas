program CalculoSalarioLiquido;
uses Crt;
// { Disciplina  : [Linguagem e L�gica de Programa��o]}
// { Professor   : Rovilson de Freitas}
// { Descri��o   : Calcular sal�rio l�quido}
// { Autor(a)    : Matheus Poldioro}
// { Data atual  : 24/08/2021}
Var
SalarioBruto, HoraExtra, inss, IR, SalarioLiquido : real;

begin
   // { Entrada de dados}
   write ('Digite o s�lario Bruto desse m�s: ');
   readln (SalarioBruto);
   write ('Digite o valor recebido de horas extras desse m�s: ');
   readln (HoraExtra);
   write ('Digite o desconto do INSS desse m�s: ');
   readln (inss);
   write ('Digite o desconto do IR desse m�s: ');
   readln (IR);

   // {processamento}
   SalarioLiquido := SalarioBruto + HoraExtra -  inss - IR;

   // { Saida}
   write( 'O seu s�rio Liquido desse m�s � de: ', SalarioLiquido);

end.