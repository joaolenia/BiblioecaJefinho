using System;
using System.Collections.Generic;
public class Funcionario : Pessoa
{
    private string cargo;

    public Funcionario(string nome, string documento, string cargo)
        : base(nome, documento)
    {
        this.cargo = cargo;
    }

    public string Cargo
    {
        get { return cargo; }
        set { cargo = value; }
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Cargo: {Cargo}";
    }
}