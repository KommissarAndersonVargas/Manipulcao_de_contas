using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     class Conta
    {
    public int ID { get; set; }
    public string nome { get; set; }

    public double dinheiro { get; set; }

    public Conta(int iD, string nome, double dinheiro)
    {
        ID = iD;
        this.nome = nome;
        this.dinheiro = dinheiro;
    }

    public void AddMoney(double valor)
    {
        dinheiro = valor + dinheiro;
    }
    public void SubtraMoney(double valor)
    {
        dinheiro = dinheiro - valor;
    }
    public void Transfer(Conta client, double valor)
    {
        client.AddMoney(valor);
        SubtraMoney(valor);
    }

    public override string ToString()
    {
        return "----------------------------"
                 +
                "\nNome: " + nome + "\n" + "Id: " + ID + "\n" + "Dinheiro: " + dinheiro +
                "\n---------------------------\n";
            
            
    }
}


