package appaleatorio.principal;

public class ItemList {

    private String nome;

    public ItemList(String nome) {
        this.nome = nome.toUpperCase();
    }

    public String getName() {
        return nome;
    }

    public void setName(String nome) {
        this.nome = nome;
    }
}

