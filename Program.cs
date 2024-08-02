namespace BiblioecaJefinho;
class Program
{
	static void Main()
	{
		IBiblioteca biblioteca = new Biblioteca();

		while (true)
		{
			Console.WriteLine("Escolha uma opção:");
			Console.WriteLine("1. Adicionar Pessoa");
			Console.WriteLine("2. Adicionar Livro");
			Console.WriteLine("3. Realizar Empréstimo");
			Console.WriteLine("4. Devolver Livro");
			Console.WriteLine("5. Listar Empréstimos");
			Console.WriteLine("6. Listar Livros");
			Console.WriteLine("7. Sair");

			string opcao = Console.ReadLine();

			switch (opcao)
			{
				case "1":
					AdicionarPessoa(biblioteca);
					break;
					
				case "2":
					AdicionarLivro(biblioteca);
					break;
				case "3":
					biblioteca.RealizarEmprestimo();
					break;
				case "4":
					biblioteca.DevolverLivro();
					break;
				case "5":
					biblioteca.ListarEmprestimos();
					break;
					
				case "6":
					biblioteca.ListarLivros();
					break;
				case "7":
					return;
				default:
					Console.WriteLine("Opção inválida.");
					break;
			}
		}
	}

	static void AdicionarPessoa(IBiblioteca biblioteca)
	{
		Console.WriteLine("Digite o tipo de pessoa (Funcionario/Estudante):");
		string tipo = Console.ReadLine();

		Console.WriteLine("Digite o nome:");
		string nome = Console.ReadLine();

		Console.WriteLine("Digite o documento:");
		string documento = Console.ReadLine();

		if (tipo.Equals("Funcionario", StringComparison.OrdinalIgnoreCase))
		{
			Console.WriteLine("Digite o cargo:");
			string cargo = Console.ReadLine();
			biblioteca.AdicionarPessoa(new Funcionario(nome, documento, cargo));
		}
		else if (tipo.Equals("Estudante", StringComparison.OrdinalIgnoreCase))
		{
			Console.WriteLine("Digite a matrícula:");
			string matricula = Console.ReadLine();
			biblioteca.AdicionarPessoa(new Estudante(nome, documento, matricula));
		}
		else
		{
			Console.WriteLine("Tipo de pessoa inválido.");
		}
	}
	
		static void AdicionarLivro(IBiblioteca biblioteca)
	{
		Console.WriteLine("Digite a categoria do livro:");
		string categoria = Console.ReadLine();

		Console.WriteLine("Digite o titúlo:");
		string titulo = Console.ReadLine();

		Console.WriteLine("Digite o nome do autor:");
		string autor = Console.ReadLine();
		
		Livro livro= new Livro(titulo,autor,categoria);
		
		biblioteca.AdicionarLivro(new Livro(titulo,autor,categoria));

	}
}