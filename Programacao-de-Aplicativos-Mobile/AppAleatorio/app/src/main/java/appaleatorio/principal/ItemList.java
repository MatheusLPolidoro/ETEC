package appaleatorio.principal;

import android.graphics.Color;
import android.text.Spannable;
import android.text.SpannableString;
import android.text.style.BackgroundColorSpan;
import android.text.style.ForegroundColorSpan;

public class ItemList {

    private final Spannable nome;

    public ItemList(String nome) {
        Spannable sText = new SpannableString(nome.toUpperCase().trim());
        sText.setSpan(new ForegroundColorSpan(Color.TRANSPARENT), 0,1,0);
        this.nome = sText;
    }
    public Spannable getName() {
        return nome;
    }

}