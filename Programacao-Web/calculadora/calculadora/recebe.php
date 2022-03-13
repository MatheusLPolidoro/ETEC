<?php
// Receber valores
$valorConta = $_POST["valorConta"];
$qtdPessoas = $_POST["qtdPessoas"];

// Calcular valores
$taxaServico = $valorConta * 0.1;
$valorFinal = $valorConta + $taxaServico;
$valorpessoa = $valorFinal / $qtdPessoas;

// Mostrar resultado
echo "<strong>Valor da conta: $valorConta</stong><br>";             //valor conta
echo "<strong>Quantidade de pessoas: $qtdPessoas</stong><br>";      //quantidade de pessoas
echo "<strong>Valor da taxa de serviço: $taxaServico</stong><br>";  //valor da taxa de serviço de 10%
echo "<strong>Valor final da conta: $valorFinal</stong><br>";       //valor final da conta
echo "<strong>Valor por pessoa: $valorpessoa</stong><br>";                      //valor por pessoa
?>