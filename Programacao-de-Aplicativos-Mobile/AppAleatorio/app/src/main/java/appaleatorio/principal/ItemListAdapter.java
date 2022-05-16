package appaleatorio.principal;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class ItemListAdapter extends RecyclerView.Adapter<ItemListViewHolder> {

    private Context context;
    private ArrayList<ItemList> itens;

    public ItemListAdapter(Context context, ArrayList<ItemList> itens) {
        this.context = context;
        this.itens = itens;
    }


    @NonNull
    @Override
    public ItemListViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.list_item, parent, false);
        ItemListViewHolder viewHolder = new ItemListViewHolder(view);
        return viewHolder;
    }

    @Override
    public void onBindViewHolder(@NonNull ItemListViewHolder holder, int position) {
        ItemList itemList = itens.get(position);
        holder.nome.setText(itemList.getName());
    }

    @Override
    public int getItemCount() {
        return itens.size();
    }
}
