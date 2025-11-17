using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestKana
{
    [Serializable]
    public class Score
    {
        protected string kanaChoix;
        protected string note;
        protected string dateHeure;

        public Score(string kanaChoix, string note, string dateHeure)
        {
            this.kanaChoix = kanaChoix;
            this.note = note;
            this.dateHeure = dateHeure;
        }

        public string getInfos()
        {
            return "Test " + kanaChoix + " " + note + " | " + dateHeure;
        }
    }
}
