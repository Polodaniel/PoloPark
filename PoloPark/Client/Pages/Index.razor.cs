using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace PoloPark.Client.Pages
{
    public class IndexBase : ComponentBase
    {
        #region Propriedades
        protected string Titulo { get; set; }
        #endregion

        #region Contrutor
        public IndexBase()
        {
            Titulo = "Dashboad";
        }
        #endregion

        #region Eventos

        #endregion

        #region Graficos
        public int Index = 0;

        public List<ChartSeries> Series = new List<ChartSeries>()
        {
            new ChartSeries() { Name = "Veiculo", Data = new double[] { 3, 6, 4, 1 } },
        };
        public string[] XAxisLabels = { "Carro", "Moto", "Camionete", "Caminhão"};
        #endregion
    }
}
