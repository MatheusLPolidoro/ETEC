package appaleatorio.principal;


import android.view.View;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;


public class ItemListViewHolder extends RecyclerView.ViewHolder {
    private ItemListAdapter adapter;
    public TextView nome;

    public ItemListViewHolder(@NonNull View itemView) {
        super(itemView);
        nome = itemView.findViewById(R.id.nome);
        itemView.findViewById(R.id.imgBtnRemove).setOnClickListener(view -> {
            ActPrincipal.updateRemove(getAdapterPosition(), nome.getText().toString());
            adapter.itens.remove(getAdapterPosition());
            adapter.notifyItemRemoved(getAdapterPosition());
            ActPrincipal.updateScreen();
        });
    }

    public ItemListViewHolder linkAdapter(ItemListAdapter adapter){
        this.adapter = adapter;
        return this;
    }
}
