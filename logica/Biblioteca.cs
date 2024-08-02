
public class Biblioteca : IBiblioteca
{
	private List<Pessoa> pessoas = new List<Pessoa>();
	private List<Emprestimo> emprestimos = new List<Emprestimo>();
	private List<Livro> livros =new List<Livro>(); 
	public void AdicionarPessoa(Pessoa pessoa){
		pessoas.Add(pessoa);
		Console.WriteLine("Pessoa adicionada com sucesso!");
	}
	
	public void AdicionarLivro(Livro livro)
	{
		livros.Add(livro);
		Console.WriteLine("Livro Adicionado com Sucessso");
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

		Console.WriteLine("Digite o titulo do livro:");
		string titulo = Console.ReadLine();
		
		Livro livro = livros.Find(l => l.Titulo == titulo);

		if (livro == null)
		{
			Console.WriteLine("Livro não encontrado.");
			return;
		}
		else{
		
		Emprestimo emprestimo = new Emprestimo(pessoa, livro, DateTime.Now);
		emprestimos.Add(emprestimo);
		Console.WriteLine("Empréstimo realizado com sucesso!");
		}
	
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

		Console.WriteLine("Digite o titulo do livro:");
		string titulo = Console.ReadLine();
		
		Livro livro = livros.Find(l => l.Titulo == titulo);

		if (livro == null)
		{
			Console.WriteLine("Livro não encontrado.");
			return;
		}
		Emprestimo emprestimo = emprestimos.Find(e => e.Pessoa == pessoa && e.Livro == livro && !e.DataDevolucao.HasValue);

		if (emprestimo == null)
		{
			Console.WriteLine("Empréstimo não encontrado ou livro já devolvido.");
			return;
		}

		emprestimo.DevolverLivro(DateTime.Now);
		Console.WriteLine("Livro devolvido com sucesso!");
	}

	public void ListarEmprestimos(){

		foreach (var emprestimo in emprestimos){
			Console.WriteLine(emprestimo);
		}
	}
	
	public void ListarLivros(){
		
		foreach(var livro in livros){
			Console.WriteLine(livro);
		}
	}
}