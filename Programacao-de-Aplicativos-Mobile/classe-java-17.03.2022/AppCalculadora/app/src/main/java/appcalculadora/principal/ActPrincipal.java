package appcalculadora.principal;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class ActPrincipal extends AppCompatActivity {

    EditText lbAnoAtual, lbAnoNasc;
    TextView txtIdade;

    @Override  // Anotação para sobrescrever o metodo
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_act_principal);

        lbAnoAtual = findViewById(R.id.lbAnoAtual);
        lbAnoNasc = findViewById(R.id.lbAnoNasc);
        txtIdade = findViewById(R.id.txtIdade);
    }

    public void calcularIdade(View view){
        int anoAtual = 0, anoNasc = 0, idade = 0;
        try {
            anoAtual = Integer.parseInt(lbAnoAtual.getText().toString());
            anoNasc = Integer.parseInt(lbAnoNasc.getText().toString());
            idade = anoAtual - anoNasc;
        }catch (NumberFormatException nexc){
            txtIdade.setText("Preencha os campos");
        }
        if (idade != 0) {
            txtIdade.setText(String.valueOf(idade));
        }
    }


}