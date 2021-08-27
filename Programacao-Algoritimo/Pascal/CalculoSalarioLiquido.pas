program CalculoSalarioLiquido;
uses Crt;
// { Disciplina  : [Linguagem e Lógica de Programação]}
// { Professor   : Rovilson de Freitas}
// { Descrição   : Calcular salário láquido}
// { Autor(a)    : Matheus Poldioro}
// { Data atual  : 24/08/2021}
Var
SalarioBruto, HoraExtra, inss, IR, SalarioLiquido : real;

begin
   // { Entrada de dados}
   write ('Digite o sálario Bruto desse mês: ');
   readln (SalarioBruto);
   write ('Digite o valor recebido de horas extras desse mês: ');
   readln (HoraExtra);
   write ('Digite o desconto do INSS desse mês: ');
   readln (inss);
   write ('Digite o desconto do IR desse mês: ');
   readln (IR);

   // {processamento}
   SalarioLiquido := SalarioBruto + HoraExtra -  inss - IR;

   // { Saida}
   write( 'O seu sário Liquido desse mês é de: ', SalarioLiquido);

end.