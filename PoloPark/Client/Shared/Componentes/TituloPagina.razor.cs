using Microsoft.AspNetCore.Components;

namespace PoloPark.Client.Shared.Componentes
{
    public class TituloPaginaBase : ComponentBase
    {
        #region Parametros
        [Parameter]
        public string Titulo { get; set; }
        #endregion
    }
}
