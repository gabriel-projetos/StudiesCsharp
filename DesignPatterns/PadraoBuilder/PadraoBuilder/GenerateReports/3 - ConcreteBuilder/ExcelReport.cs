using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternBuilder.Builder;

namespace PatternBuilder.ConcreteBuilder
{
    /// <summary>
    /// Concrete Builder
    ///  A classe ConcreteBuilder implementa a interface Builder e fornece implementação para todos os métodos abstratos.
    /// O Concrete Builder é responsável por construir e montar as partes individuais do produto implementando a interface do Builder.
    /// Ele também define e rastreia a representação que cria.
    /// </summary>
    public class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content Section";
        }
        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }
        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }
}
