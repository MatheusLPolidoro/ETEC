package appescola.controle;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

public class actPrincipal extends AppCompatActivity {
    ImageView imgSplash;
    Handler splashScreen = new Handler();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_act_principal);
        imgSplash = findViewById(R.id.imgSplash);
        imgSplash.animate().setDuration(4000);
        imgSplash.animate().alpha(0.1f).start();
        splashScreen.postDelayed(new Runnable() {
            @Override
            public void run(){
                selectLayout();
            }
        }, 4000);
    }
    public void selectLayout(){
        Intent switchLayout = new Intent(this, actLogin.class);
        startActivity(switchLayout);
        finish();
    }

}