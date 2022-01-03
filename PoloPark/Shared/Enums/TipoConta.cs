using System.ComponentModel;

namespace PoloPark.Shared.Enums
{
    public enum TipoConta
    {
        /// <summary>
        /// Tipo de Conta para teste do sistema com Data de Inicio e Termino de Teste.
        /// </summary>
        [Description("Conta de Teste")]
        ContaTeste = 0,

        /// <summary>
        /// Conta Free liberado para todos os usuarios que realizarem o cadastro.
        /// </summary>
        [Description("Conta Grátis")]
        ContaFree = 1,

        /// <summary>
        ///  Conta Bronze possui os mesmos beneficios da contra free e beneficios liberado para essa categoria. 
        /// </summary>
        [Description("Conta Bronze")]
        ContaBronze = 2,

        /// <summary>
        ///  Conta Prata possui os mesmos beneficios da contra bronze e beneficios liberado para essa categoria. 
        /// </summary>
        [Description("Conta Prata")]
        ContaPrata = 3,

        /// <summary>
        ///  Conta Ouro possui os mesmos beneficios da contra prata e beneficios liberado para essa categoria. 
        /// </summary>
        [Description("Conta Ouro")]
        ContaOuro = 4,

        /// <summary>
        /// Conta do Gerencial do Sistema.
        /// </summary>
        [Description("Conta Gerencial")]
        ContaGerencial = 98,

        /// <summary>
        /// Conta do Administrador do Sistema.
        /// </summary>
        [Description("Conta Administrativa")]
        ContaAdministrador = 99
    }
}
