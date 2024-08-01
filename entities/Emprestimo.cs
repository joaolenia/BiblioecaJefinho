public class Emprestimo
{
	public Pessoa Pessoa { get; set; }
	public string Livro { get; set; }
	public DateTime DataEmprestimo { get; set; }
	public DateTime? DataDevolucao { get; set; }

	public Emprestimo(Pessoa pessoa, string livro, DateTime dataEmprestimo)
	{
		Pessoa = pessoa;
		Livro = livro;
		DataEmprestimo = dataEmprestimo;
		DataDevolucao = null;
	}

	public void DevolverLivro(DateTime dataDevolucao)
	{
		DataDevolucao = dataDevolucao;
	}

	public override string ToString()
	{
		return $"{Pessoa} - Livro: {Livro}, Data Empréstimo: {DataEmprestimo.ToShortDateString()}, Data Devolução: {(DataDevolucao.HasValue ? DataDevolucao.Value.ToShortDateString() : "Não devolvido")}";
	}
}