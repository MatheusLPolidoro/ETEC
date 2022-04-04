package calculadora.principal;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.util.regex.Pattern;

public class CalculadoraAct extends AppCompatActivity {

    TextView txtResultado;
    EditText edtValor;
    Button btnSomar, btnSubtrair, btnDividir, btnMultiplicar, btnIgual;

    private float numero1, numero2, resultado;
    private String operacao;
    private Pattern pattern = Pattern.compile("-?\\d+(\\.\\d+)?");

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calculadora);
        txtResultado = findViewById(R.id.txtResultado);
        edtValor = findViewById(R.id.edtValor);
        btnSomar = findViewById(R.id.btnSomar);
        btnSubtrair = findViewById(R.id.btnSubtrair);
        btnMultiplicar = findViewById(R.id.btnMultiplicar);
        btnDividir = findViewById(R.id.btnDividir);
        btnIgual = findViewById(R.id.btnIgual);
        btnIgual.setEnabled(false);
    }

    public void limpar(View view){
        edtValor.setText("");
        txtResultado.setText("");
        edtValor.requestFocus();
        btnSomar.setEnabled(true);
        btnSubtrair.setEnabled(true);
        btnDividir.setEnabled(true);
        btnMultiplicar.setEnabled(true);
        btnIgual.setEnabled(false);
    }

    public void calc(View view){
        edtValor.setText("");
        edtValor.requestFocus();
        btnSomar.setEnabled(true);
        btnSubtrair.setEnabled(true);
        btnDividir.setEnabled(true);
        btnMultiplicar.setEnabled(true);
        btnIgual.setEnabled(false);
    }

    public void somar(View view){
        if (validate()) {
            txtResultado.setText("");
            operacao = "+";
            numero1 = Float.parseFloat(edtValor.getText().toString());
            txtResultado.setText(String.valueOf(numero1) + " + ");
            calc(view);
            btnSomar.setEnabled(false);
            btnIgual.setEnabled(true);
        }
    }

    public void subtrair(View view){
        if (validate()) {
            txtResultado.setText("");
            operacao = "-";
            numero1 = Float.parseFloat(edtValor.getText().toString());
            txtResultado.setText(String.valueOf(numero1) + " - ");
            btnSubtrair.setEnabled(false);
            calc(view);
            btnSubtrair.setEnabled(false);
            btnIgual.setEnabled(true);
        }
    }

    public void multiplicar(View view){
        if (validate()) {
            txtResultado.setText("");
            operacao = "*";
            numero1 = Float.parseFloat(edtValor.getText().toString());
            txtResultado.setText(String.valueOf(numero1) + " * ");
            btnMultiplicar.setEnabled(false);
            calc(view);
            btnMultiplicar.setEnabled(false);
            btnIgual.setEnabled(true);
        }
    }

    public void dividir(View view){
        if (validate()) {
            txtResultado.setText("");
            operacao = "/";
            numero1 = Float.parseFloat(edtValor.getText().toString());
            txtResultado.setText(String.valueOf(numero1) + " / ");
            btnDividir.setEnabled(false);
            calc(view);
            btnDividir.setEnabled(false);
            btnIgual.setEnabled(true);
        }
    }

    public boolean validate(){
        if (!edtValor.getText().toString().equals("") && isNumeric(edtValor.getText().toString())) {
            return true;
        }else{
            return false;
        }
    }

    public boolean isNumeric(String strNum) {
        if (strNum == null) {
            return false;
        }
        return pattern.matcher(strNum).matches();
    }

    public void igual(View view) {
        if (validate()){
            numero2 = Float.parseFloat(edtValor.getText().toString());

            switch (operacao) {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                default:
                    resultado = 0;
                    break;
            }
            txtResultado.setText(txtResultado.getText() + String.valueOf(numero2) + " = " + String.valueOf(resultado));
            calc(view);
        }
    }
}