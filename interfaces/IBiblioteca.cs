using System;
using System.Collections.Generic;
public interface IBiblioteca
{
	void AdicionarPessoa(Pessoa pessoa);
	void RealizarEmprestimo();
	void DevolverLivro();
	void ListarEmprestimos();
    void AdicionarLivro(Livro livro);
	void ListarLivros();
}