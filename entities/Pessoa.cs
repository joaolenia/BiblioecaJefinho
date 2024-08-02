using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography;
public class Pessoa
{
    private string nome;
    private string documento;

    public Pessoa(string nome, string documento)
{
        this.nome = nome;
        this.documento = documento;
    }

    public string Nome{
        get { return nome; }
        set { nome = value; }
    }

    public string Documento{
        get { return documento; }
        set { documento = value; }
    }

        public override string ToString(){
        return $"{Nome}| Documento:{Documento}|";
    }

}