package appaleatorio.principal;

public class ItemList {

    private final String nome;

    public ItemList(String nome) {
        this.nome = nome.toUpperCase();
    }

    public String getName() {
        return nome;
    }

}