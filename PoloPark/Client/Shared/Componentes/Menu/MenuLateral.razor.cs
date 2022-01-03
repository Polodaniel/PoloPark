using Microsoft.AspNetCore.Components;
using PoloPark.Shared.Enums;

namespace PoloPark.Client.Shared.Componentes.Menu
{
    public class MenuLateralBase : ComponentBase
    {
        #region Propriedades

        public string NomeUsuario { get; set; }

        public TipoConta Conta { get; set; }
        #endregion
    }
}
