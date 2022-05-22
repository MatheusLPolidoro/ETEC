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
            adapter.itens.remove(getAdapterPosition());
            adapter.notifyItemRemoved(getAdapterPosition());
            if (ActPrincipal.itensParticipants.isEmpty() ||
                ActPrincipal.itensTasks.isEmpty() ||
                ActPrincipal.itensRandom.isEmpty()){
                ActPrincipal.txtResult.setVisibility(View.INVISIBLE);
                ActPrincipal.itensRandom.clear();
            }
            for(int i = 0; i < ActPrincipal.strItensParticipants.size(); i++)
            {
                String item = ActPrincipal.strItensParticipants.get(i);
                if(item.equals(nome.getText().toString())) {
                    ActPrincipal.strItensParticipants.remove(i);
                    break;
                }
            }
            for(int i = 0; i < ActPrincipal.strItensTasks.size(); i++)
            {
                String item = ActPrincipal.strItensTasks.get(i);
                if(item.equals(nome.getText().toString())) {
                    ActPrincipal.strItensTasks.remove(i);
                    break;
                }
            }
            ActPrincipal.rvResize(ActPrincipal.itensParticipants, ActPrincipal.rvParticipants);
            ActPrincipal.rvResize(ActPrincipal.itensTasks, ActPrincipal.rvTasks);
            ActPrincipal.rvResize(ActPrincipal.itensRandom, ActPrincipal.rvRandom);
        });
    }

    public ItemListViewHolder linkAdapter(ItemListAdapter adapter){
        this.adapter = adapter;
        return this;
    }
}
