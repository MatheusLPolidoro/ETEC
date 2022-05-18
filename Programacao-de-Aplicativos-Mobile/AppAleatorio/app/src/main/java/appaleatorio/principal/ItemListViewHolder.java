package appaleatorio.principal;


import android.view.View;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;


public class ItemListViewHolder extends RecyclerView.ViewHolder {
    private ItemListAdapter adapter;
    TextView nome;

    public ItemListViewHolder(@NonNull View itemView) {
        super(itemView);

        nome = itemView.findViewById(R.id.nome);
        itemView.findViewById(R.id.imgBtnRemove).setOnClickListener(view -> {
            adapter.itens.remove(getAdapterPosition());
            adapter.notifyItemRemoved(getAdapterPosition());
        });
    }

    public ItemListViewHolder linkAdapter(ItemListAdapter adapter){
        this.adapter = adapter;
        return this;
    }
}
