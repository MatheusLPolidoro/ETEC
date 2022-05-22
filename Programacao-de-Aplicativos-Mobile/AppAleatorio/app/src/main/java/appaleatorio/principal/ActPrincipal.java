package appaleatorio.principal;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.Toast;
import java.util.ArrayList;


public class ActPrincipal extends AppCompatActivity {

    @SuppressLint("StaticFieldLeak")
    private static View txtResult;
    private static ArrayList<String> strItensParticipants;
    private static ArrayList<String> strItensTasks;
    private static ArrayList<ItemList> itensParticipants, itensTasks, itensRandom;
    private static RecyclerView rvParticipants, rvTasks, rvRandom;
    private ItemListAdapter adapterParticipants, adapterTasks, adapterRandom;
    private EditText edtName, edtTask;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_act_principal);

        txtResult = findViewById(R.id.txtResult);
        edtName = findViewById(R.id.edtName);
        edtTask = findViewById(R.id.edtTask);
        rvParticipants = findViewById(R.id.rvParticpants);
        rvTasks = findViewById(R.id.rvTasks);
        rvRandom = findViewById(R.id.rvRandom);

        itensParticipants = new ArrayList<>();
        itensTasks = new ArrayList<>();
        itensRandom = new ArrayList<>();

        strItensParticipants = new ArrayList<>();
        strItensTasks = new ArrayList<>();

        adapterParticipants = new ItemListAdapter(this, itensParticipants);
        adapterTasks = new ItemListAdapter(this, itensTasks);

        RecyclerView.LayoutManager layoutManagerParticipants = new LinearLayoutManager(this,
                LinearLayoutManager.VERTICAL, true);
        RecyclerView.LayoutManager layoutManagerTasks = new LinearLayoutManager(this,
                LinearLayoutManager.VERTICAL, true);
        RecyclerView.LayoutManager layoutManagerRandom = new LinearLayoutManager(this,
                LinearLayoutManager.VERTICAL, true);

        rvParticipants.setLayoutManager(layoutManagerParticipants);
        rvTasks.setLayoutManager(layoutManagerTasks);
        rvRandom.setLayoutManager(layoutManagerRandom);

        rvParticipants.setAdapter(adapterParticipants);
        rvTasks.setAdapter(adapterTasks);
        rvRandom.setAdapter(adapterRandom);
    }

    public void updateParticipants(View view) {
        if (edtName.getText().toString().trim().equals("") ||
            edtName.getText().toString().length() > 25){
            Toast.makeText(this, "Participante inválido", Toast.LENGTH_SHORT).show();
            return;
        }

        ItemList newItem = new ItemList("P" + edtName.getText().toString());

        if (strItensParticipants.contains(newItem.getName().toString().trim())){
            Toast.makeText(this, "Participante já cadastrado!", Toast.LENGTH_SHORT).show();
            return;
        } else {
            strItensParticipants.add("P" + edtName.getText().toString().toUpperCase().trim());
        }

        if (itensParticipants.size() > 30){
            Toast.makeText(this, "Limite de 30 participantes", Toast.LENGTH_SHORT).show();
            return;
        }

        itensParticipants.add(newItem);
        adapterParticipants = new ItemListAdapter(this, itensParticipants);
        rvParticipants.setAdapter(adapterParticipants);
        edtName.setText(null);
        rvResize(itensParticipants, rvParticipants);
    }
    public void updateTasks(View view) {
        if (edtTask.getText().toString().trim().equals("") ||
            edtTask.getText().toString().length() > 25){
            Toast.makeText(this, "Tarefa inválida", Toast.LENGTH_SHORT).show();
            return;
        }

        ItemList newItem = new ItemList("T" + edtTask.getText().toString());

        if (strItensTasks.contains(newItem.getName().toString().trim())){
            Toast.makeText(this, "Tarefa já cadastrada!", Toast.LENGTH_SHORT).show();
            return;
        }
        else{
            strItensTasks.add("T" + edtTask.getText().toString().toUpperCase().trim());
        }

        if (itensTasks.size() > 30){
            Toast.makeText(this, "Limite de 30 participantes", Toast.LENGTH_SHORT).show();
            return;
        }

        itensTasks.add(newItem);
        adapterTasks = new ItemListAdapter(ActPrincipal.this, itensTasks);
        rvTasks.setAdapter(adapterTasks);
        edtTask.setText(null);
        rvResize(itensTasks, rvTasks);
    }

    public void updateRandom(View view){
        ArrayList<Integer> participant = new ArrayList<>();
        ArrayList<Integer> task = new ArrayList<>();

        int iParticipant, iTask, cnt = 0;

        // Limpar o sorteio anterior
        itensRandom.clear();

        if (itensParticipants.isEmpty()) {
            Toast.makeText(this, "Cadastre um participante", Toast.LENGTH_SHORT).show();
            txtResult.setVisibility(View.INVISIBLE);
            return;
        }
        if (itensTasks.isEmpty()) {
            Toast.makeText(this, "Cadastre uma tarefa", Toast.LENGTH_SHORT).show();
            txtResult.setVisibility(View.INVISIBLE);
            return;
        }
        for (int i = 0; i < itensTasks.size(); i++) {
            if (itensParticipants.size() == cnt) {
                cnt = 0;
                participant.clear();
            }

            if (itensParticipants.size() == itensTasks.size()
                    && itensTasks.size() == itensRandom.size()) {
                break;
            }

            do {
                iParticipant = (int) (Math.random() * itensParticipants.size());
            } while (participant.contains(iParticipant));
            participant.add(iParticipant);

            do {
                iTask = (int) (Math.random() * itensTasks.size());
            } while (task.contains(iTask));
            task.add(iTask);

            ItemList newItem;
            newItem = new ItemList(
                    "R" + itensParticipants.get(iParticipant).getName().toString().substring(
                            1, itensParticipants.get(iParticipant).getName().length()) +
                    " / " + itensTasks.get(iTask).getName().toString().substring(
                            1, itensTasks.get(iTask).getName().length()));

            itensRandom.add(newItem);
            txtResult.setVisibility(View.VISIBLE);

            cnt++;
            rvResize(itensRandom, rvRandom);
        }

        adapterRandom = new ItemListAdapter(ActPrincipal.this, itensRandom);
        rvRandom.setAdapter(adapterRandom);
    }

    public static void rvResize(ArrayList<ItemList> itens, RecyclerView rv) {
        ViewGroup.LayoutParams params = rv.getLayoutParams();

        if (itens.size() > 5) {
            params.height = 75 * 5;
        }
        else {
            params.height = ViewGroup.LayoutParams.WRAP_CONTENT;
        }

    }

    public static void updateRemove(int rvId, String nome){

        if (nome.charAt(0) == 'P'){
            strItensParticipants.remove(rvId);
        }else if(nome.charAt(0) == 'T'){
            strItensTasks.remove(rvId);
        }

        rvResize(itensParticipants, rvParticipants);
        rvResize(itensTasks, rvTasks);
        rvResize(itensRandom, rvRandom);
    }

    public static void updateScreen(){
        if (itensParticipants.isEmpty() ||
                itensTasks.isEmpty() ||
                itensRandom.isEmpty()){
            ActPrincipal.txtResult.setVisibility(View.INVISIBLE);
            itensRandom.clear();
        }
    }
}