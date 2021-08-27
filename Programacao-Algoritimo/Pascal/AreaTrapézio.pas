program Area_trapezio;
var
    Area, BaseMaior, BaseMenor, Altura : real;

begin
    WriteLn('Programa para descobrir a area de um trapezoide');
    WriteLn('Digite um numero que se refere a base MAIOR do trapezoide: ');
    ReadLn(BaseMaior);
    WriteLn('Digite um numero que se refere a base MENOR do trapezoide: ');
    ReadLn(BaseMenor);
    WriteLn('Digite um numero que se refere a ALTURA do trapezoide: ');
    ReadLn(Altura);
    Area := (BaseMaior + BaseMenor) * Altura / 2;
    WriteLn('A area do trapezoide e de');
    WriteLn (Area);
    ReadLn(Altura);
end.
