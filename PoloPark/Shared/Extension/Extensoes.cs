using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace PoloPark.Shared.Extension
{
    public static class Extensoes
    {
        public static bool IsNullOrEmpty<TSource>(this ICollection<TSource> list) =>
            list == null || list.Count == 0;
        public static bool IsNull(this object objeto)
            => objeto == null;

        public static string ObterDescricaoEnum(this Enum enumerador)
        {
            if (enumerador == null)
                return string.Empty;

            Type tipo = enumerador.GetType();
            string nome = Enum.GetName(tipo, enumerador);

            string descricao = enumerador.ToString();

            if (nome != null)
            {
                FieldInfo campo = tipo.GetField(nome);
                if (campo != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(campo,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                        if (attr.Description != null)
                            descricao = attr.Description;
                }
            }
            return (descricao);
        }

        public static List<string> ObterListaDescricao(Type enumerador)
        {
            return (from l in Enum.GetValues(enumerador).Cast<object>().ToList()
                    select ObterDescricaoEnum((Enum)l)).ToList();
        }

        public static Dictionary<Type, string> ObterTypeDescricao(Type enumerador)
        {
            return (from l in Enum.GetValues(enumerador).Cast<object>().ToList()
                    select new { enumerador, descricao = ObterDescricaoEnum((Enum)l) })
                    .ToDictionary(x => x.enumerador, x => x.descricao);
        }
    }

}
