using Microsoft.AspNetCore.Components;

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
    }
}
