using System;

class Funcionario
{
    private string nome;
    private double salario;

    public string getNome()
    {
        return nome;
    }

    public double getSalario()
    {
        return salario;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public void setSalario(double salario)
    {
        this.salario = salario;
    }

    public void AumentarSalario(double percentual)
    {
        double aumento = salario * (percentual / 100);
        salario += aumento;
    }
}

class Program
{
    static void Main()
    {
        Funcionario funcionario = new Funcionario();

        funcionario.setNome("Carlos");
        funcionario.setSalario(2000);

        double salarioInicial = funcionario.getSalario();
        double percentual = 10;

        funcionario.AumentarSalario(percentual);

        Console.WriteLine("Funcionário: " + funcionario.getNome());
        Console.WriteLine("Salário inicial: " + salarioInicial);
        Console.WriteLine("Percentual de aumento: " + percentual + "%");
        Console.WriteLine("Novo salário: " + funcionario.getSalario());
    }
}