using PatternBuilder.ConcreteBuilder;
using PatternBuilder.Director;
using PatternBuilder.Produto;

namespace PatternBuilder
{
    internal class Program
    {
        //Builder
        //O Builder é um padrão de projeto criacional que permite a você construir objetos complexos passo a passo.
        //O padrão permite que você produza diferentes tipos e representações de um objeto usando o mesmo código de construção.


        //Passo 1 : Classe Produto: é a classe que representa o objeto complexo que será construído.Ela possui atributos e métodos para acessar e modificar esses atributos.

        //Passo 2 : Interface IBuilder: é a interface que define os métodos necessários para construir o objeto complexo.Esses métodos podem ser definidos para cada parâmetro do objeto.

        //Passo 3 : Classe ConcreteBuilder: é a classe que implementa a interface IBuilder e define como o objeto complexo será construído.Ela possui métodos para construir cada parâmetro do objeto e para retornar o objeto construído.

        //Passo 4 : Classe Director: é a classe que define a ordem em que os métodos da interface IBuilder serão chamados para construir o objeto complexo.Ela recebe um objeto ConcreteBuilder e utiliza seus métodos para construir o objeto.
        static void Main(string[] args)
        {
            // Client Code
            Report report;
            ReportDirector reportDirector = new ReportDirector();
            
            // Construct and display Reports
            PDFReport pdfReport = new PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            
            Console.WriteLine("-------------------");

            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();
        }
    }
}