package appimage.controler;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Toast;

public class actImage extends AppCompatActivity {

    public String imgRotate;
    ImageView imImage;
    Button btnRotation;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_act_image);

        imImage = findViewById(R.id.imImage);
        btnRotation = findViewById(R.id.btnRotation);
    }

    public void changeImage(View view){
        if (imImage.getDrawable().getConstantState() ==
                getResources().getDrawable(R.drawable.school_draw).getConstantState()) {
            imImage.setImageResource(R.drawable.school_real);
        }else{
            imImage.setImageResource(R.drawable.school_draw);
        }
    }

    public void imageRotate(View view){
        imImage.setRotationY(15);
        Toast.makeText(this, "Rotação Direita", Toast.LENGTH_SHORT).show();
        btnRotation.setText("Rotação Direita");
    }

    public void ImageCenter(View view){
        imImage.setRotationY(0);
        Toast.makeText(this, "Centralizar", Toast.LENGTH_SHORT).show();
        btnRotation.setText("ROTAÇÃO");
    }

}