package calculadora.principal;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class CalculadoraAct extends AppCompatActivity {

    TextView txtResultado;
    EditText edtValor;
    Button btnSomar, btnIgual;

    private float numero1, numero2, resultado;
    private String operacao;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calculadora);
        txtResultado = findViewById(R.id.txtResultado);
        edtValor = findViewById(R.id.edtValor);
        btnSomar = findViewById(R.id.btnSomar);
        btnIgual = findViewById(R.id.btnIgual);
        btnIgual.setEnabled(false);
    }

    public void limpar(View view){
        edtValor.setText("");
        edtValor.requestFocus();
        btnIgual.setEnabled(true);
        btnSomar.setEnabled(false);
    }
    public void somar(View view){
        operacao = "+";
        numero1 = Float.parseFloat(edtValor.getText().toString());
        txtResultado.setText(String.valueOf(numero1) + " + ");
        limpar(view);
    }

    public void igual(View view) {
        if (!edtValor.getText().toString().equals("")) {
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
            txtResultado.setText(txtResultado.getText() + " + " + String.valueOf(numero2) + " = " + String.valueOf(resultado));
            limpar(view);
        }
    }
}