using System;
using System.Collections.Generic;
public class Estudante : Pessoa
{
    private string matricula;

    public Estudante(string nome, string documento, string matricula)
        : base(nome, documento){
        this.matricula = matricula;
    }

    public string Matricula{
        get { return matricula; }
        set { matricula = value; }
    }

    public override string ToString(){
        return $"{base.ToString()}| Matrícula: {Matricula}";
    }
}