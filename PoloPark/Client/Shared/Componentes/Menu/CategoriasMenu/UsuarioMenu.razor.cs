using Microsoft.AspNetCore.Components;
using PoloPark.Shared.Enums;

namespace PoloPark.Client.Shared.Componentes.Menu.CategoriasMenu
{
    public class UsuarioMenuBase : ComponentBase
    {
        #region Parametros
        [Parameter]
        public string NomeUsuario { get; set; }

        [Parameter]
        public TipoConta Conta { get; set; }
        #endregion
    }
}
