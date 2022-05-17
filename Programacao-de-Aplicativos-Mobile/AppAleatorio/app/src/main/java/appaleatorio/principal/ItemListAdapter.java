package appaleatorio.principal;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class ItemListAdapter extends RecyclerView.Adapter<ItemListViewHolder> {

    private final Context context;
    public ArrayList<ItemList> items;

    public ItemListAdapter(Context context, ArrayList<ItemList> items) {
        this.context = context;
        this.items = items;
    }


    @NonNull
    @Override
    public ItemListViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.list_item, parent, false);
        return new ItemListViewHolder(view).linkAdapter(this);
    }

    @Override
    public void onBindViewHolder(@NonNull ItemListViewHolder holder, int position) {
        ItemList itemList = items.get(position);
        holder.nome.setText(itemList.getName());
    }

    @Override
    public int getItemCount() {
        return items.size();
    }
}
