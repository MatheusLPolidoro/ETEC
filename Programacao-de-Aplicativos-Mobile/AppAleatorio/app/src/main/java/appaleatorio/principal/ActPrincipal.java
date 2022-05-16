package appaleatorio.principal;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.util.ArrayList;

public class ActPrincipal extends AppCompatActivity {

    private ItemListAdapter adapterParticipants, adapterTasks, adapterRandom;
    private ArrayList<ItemList> itensParticipants, itensTasks, itensRandom;

    Button btnAddParticipants, btnAddTasks, btnRandom;
    EditText edtName, edtTask;
    RecyclerView rvParticipants, rvTasks, rvRandom;
    TextView txtResult;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_act_principal);

        txtResult = findViewById(R.id.txtResult);
        btnAddParticipants = findViewById(R.id.btnAdd);
        btnAddTasks = findViewById(R.id.btnAddTask);
        btnRandom = findViewById(R.id.btnRandom);
        edtName = findViewById(R.id.edtName);
        edtTask = findViewById(R.id.edtTask);
        rvParticipants = findViewById(R.id.rvParticpants);
        rvTasks = findViewById(R.id.rvTasks);
        rvRandom = findViewById(R.id.rvRandom);

        itensParticipants = new ArrayList<ItemList>();
        itensTasks = new ArrayList<ItemList>();
        itensRandom = new ArrayList<ItemList>();

        adapterParticipants = new ItemListAdapter(ActPrincipal.this, itensParticipants);
        adapterTasks = new ItemListAdapter(ActPrincipal.this, itensTasks);

        RecyclerView.LayoutManager layoutManagerParticipants = new LinearLayoutManager(ActPrincipal.this,
                LinearLayoutManager.VERTICAL, false);
        RecyclerView.LayoutManager layoutManagerTasks = new LinearLayoutManager(ActPrincipal.this,
                LinearLayoutManager.VERTICAL, false);
        RecyclerView.LayoutManager layoutManagerRandom = new LinearLayoutManager(ActPrincipal.this,
                LinearLayoutManager.VERTICAL, false);

        rvParticipants.setLayoutManager(layoutManagerParticipants);
        rvTasks.setLayoutManager(layoutManagerTasks);
        rvRandom.setLayoutManager(layoutManagerRandom);

        rvParticipants.setAdapter(adapterParticipants);
        rvTasks.setAdapter(adapterTasks);
        rvRandom.setAdapter(adapterRandom);
    }

    public void updateParticipants(View view) {
        if (! edtName.getText().toString().trim().equals("") && itensParticipants.size() < 30) {
            ItemList newItem = new ItemList(edtName.getText().toString());
            itensParticipants.add(0, newItem);
            adapterParticipants = new ItemListAdapter(ActPrincipal.this, itensParticipants);
            rvParticipants.setAdapter(adapterParticipants);
            edtName.setText(null);
        }
        rvResize(itensParticipants, rvParticipants);
    }
    public void updateTasks(View view) {
        if (! edtTask.getText().toString().trim().equals("") && itensParticipants.size() > 0) {
            ItemList newItem = new ItemList(edtTask.getText().toString());
            itensTasks.add(0, newItem);
            adapterTasks = new ItemListAdapter(ActPrincipal.this, itensTasks);
            rvTasks.setAdapter(adapterTasks);
            edtTask.setText(null);
        }
        rvResize(itensTasks, rvTasks);
    }

    public void updateRandom(View view){
        ArrayList<Integer> participant = new ArrayList();
        ArrayList<Integer> task = new ArrayList();
        int iParticipant, iTask, cnt = 0;

        // Limpar o sorteio anterior
        itensRandom.clear();

        //
        for (int i = 0; i < itensTasks.size(); i++) {
            do {
                iParticipant = (int) (Math.random() * itensParticipants.size());
            } while (participant.contains(iParticipant) && itensParticipants.size() != cnt);
            participant.add(iParticipant);

            do {
                iTask = (int) (Math.random() * itensTasks.size());
            } while (task.contains(iTask));
            task.add(iTask);

            if (itensParticipants.size() == cnt || itensParticipants.size() == itensTasks.size()
            && itensTasks.size() == itensRandom.size()){
                break;
            }

            ItemList newItem = new ItemList(itensParticipants.get(iParticipant).getName() +
                    " / " + itensTasks.get(iTask).getName());
            itensRandom.add(newItem);
            txtResult.setVisibility(view.VISIBLE);

            cnt++;
        }

        rvResize(itensRandom, rvRandom);
        adapterRandom = new ItemListAdapter(ActPrincipal.this, itensRandom);
        rvRandom.setAdapter(adapterRandom);
    }

    private void removerItem(int position,ArrayList<ItemList> itens, ItemListAdapter adapter) {
        itens.remove(position);
        adapter.notifyItemRemoved(position);
        adapter.notifyItemRangeChanged(position, itens.size());
    }

    public void rvResize( ArrayList<ItemList> itens, RecyclerView rv) {
        ViewGroup.LayoutParams params = rv.getLayoutParams();

        if (itens.size() > 5) {
            params.height = 75 * 5;
        }else{
            params.height = 75 * (itens.size());
        }
    }
}