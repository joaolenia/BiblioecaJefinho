using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
public class Livro
{
	private string titulo;
	 private string categoria;
	private string autor;

	public Livro(string titulo, string autor, String categoria)
	{
		this.titulo = titulo;
		this.autor = autor;
		this.categoria = categoria;
	}

	public string Titulo
	{
		get { return titulo; }
		set { titulo = value; }
	}

	public string Autor
	{
		get { return autor; }
		set { autor = value; }
	}
	
	
	public string Categoria
	{
		get { return categoria; }
		set { categoria = value; }
	}

	public override string ToString()
	{
		return $"Titúlo:{titulo} Autor:{autor} Categoria:{categoria}";
	}
}