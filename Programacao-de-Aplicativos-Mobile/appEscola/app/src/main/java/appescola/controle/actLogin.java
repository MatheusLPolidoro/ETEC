package appescola.controle;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class actLogin extends AppCompatActivity {

    EditText edtUser, edtPassword;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_act_login);
        edtUser = findViewById(R.id.edtUser);
        edtPassword = findViewById(R.id.edtPassword);
    }

    public void validateLogin(View view) {

        if (edtUser.getText().toString().trim().equals("etec") && edtPassword.getText().toString().trim().equals("1234")) {
            startActivity(new Intent(this, actMenu.class));
            finish();
        }
        else{
            Toast.makeText(this, "Login Inválido", Toast.LENGTH_LONG).show();
            edtUser.setText("");
            edtPassword.setText("");
        }

    }


}