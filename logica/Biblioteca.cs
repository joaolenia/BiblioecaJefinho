86% de armazenamento usado … Se você atingir o limite, não será possível criar, editar ou fazer upload de arquivos. Aproveite 100 GB de armazenamento por R$ 7,99 R$ 0 durante um mês.
public class Biblioteca : IBiblioteca
{
	private List<Pessoa> pessoas = new List<Pessoa>();
	private List<Emprestimo> emprestimos = new List<Emprestimo>();

	public void AdicionarPessoa(Pessoa pessoa)
	{
		pessoas.Add(pessoa);
		Console.WriteLine("Pessoa adicionada com sucesso!");
	}

	public void RealizarEmprestimo()
	{
		Console.WriteLine("Digite o nome da pessoa:");
		string nome = Console.ReadLine();
		Pessoa pessoa = pessoas.Find(p => p.Nome == nome);

		if (pessoa == null)
		{
			Console.WriteLine("Pessoa não encontrada.");
			return;
		}

		Console.WriteLine("Digite o nome do livro:");
		string livro = Console.ReadLine();
		Emprestimo emprestimo = new Emprestimo(pessoa, livro, DateTime.Now);
		emprestimos.Add(emprestimo);
		Console.WriteLine("Empréstimo realizado com sucesso!");
	}

	public void DevolverLivro()
	{
		Console.WriteLine("Digite o nome da pessoa:");
		string nome = Console.ReadLine();
		Pessoa pessoa = pessoas.Find(p => p.Nome == nome);

		if (pessoa == null)
		{
			Console.WriteLine("Pessoa não encontrada.");
			return;
		}

		Console.WriteLine("Digite o nome do livro:");
		string livro = Console.ReadLine();
		Emprestimo emprestimo = emprestimos.Find(e => e.Pessoa == pessoa && e.Livro == livro && !e.DataDevolucao.HasValue);

		if (emprestimo == null)
		{
			Console.WriteLine("Empréstimo não encontrado ou livro já devolvido.");
			return;
		}

		emprestimo.DevolverLivro(DateTime.Now);
		Console.WriteLine("Livro devolvido com sucesso!");
	}

	public void ListarEmprestimos()
	{
		foreach (var emprestimo in emprestimos)
		{
			Console.WriteLine(emprestimo);
		}
	}
}