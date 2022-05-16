package appaleatorio.principal;


import android.view.View;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;


public class ItemListViewHolder extends RecyclerView.ViewHolder {

    TextView nome;

    public ItemListViewHolder(@NonNull View itemView) {
        super(itemView);
        nome = itemView.findViewById(R.id.nome);
    }
}
