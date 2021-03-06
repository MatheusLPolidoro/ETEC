<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercicios</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<style>
    * {
        background-color: #2c6f2f;
    }

    div {
        margin-top: 3%;
    }

    [data-tooltip] {
        position: relative;
        font-weight: bold;
    }

    [data-tooltip]:after {
        display: none;
        position: absolute;
        font-size: 15px;
        top: calc(100% + 2px);
        content: attr(data-tooltip);
        white-space: nowrap;
        color: #FFF;
    }

    [data-tooltip]:hover:after {
        z-index: 98;
        display: block;
    }
</style>

<body>
    <h1>LAÇO DE REPETIÇÃO &#8635;</h1>
    <div>
        <a href="ex01.php" data-tooltip="&#x1F58A; Múltiplos de 5 e 9">Exercício 1</a><br>
        <a href="ex02.php" data-tooltip="&#x1F58A; Múltiplos de 10">Exercício 2</a><br>
        <a href="ex03.php" data-tooltip="&#x1F58A; Repetir frase">Exercício 3</a><br>
        <a href="ex04.php" data-tooltip="&#x1F58A; FizzBuzz">Exercício 4</a><br>
        <a href="ex05.php" data-tooltip="&#x1F58A Tabuada">Exercício 5</a><br>
        <a href="ex06.php" data-tooltip="&#x1F58A Números Aleatórios">Exercício 6</a><br>
    </div>
</body>

</html>