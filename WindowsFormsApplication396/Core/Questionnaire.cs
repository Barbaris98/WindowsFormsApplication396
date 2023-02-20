using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication396.Core
{
    /// <summary>
    /// Опросник.
    /// Содержит список вопросов.
    /// </summary>
    [Serializable]
    public class Questionnaire : List<Quest>
    {
    }

    /// <summary>
    /// Вопрос.
    /// Содержит список альтернатив.
    /// </summary>
    [Serializable]
    public class Quest : List<Alternative>
    {
        /// <summary>
        /// Идентификатор вопроса
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string Title { get; set; }
    }

    /// <summary>
    /// Альтернатива вопроса
    /// </summary>
    [Serializable]
    public class Alternative
    {
        /// <summary>
        /// Код альтернативы
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Текст альтернативы
        /// </summary>
        public string Title { get; set; }
    }
}
