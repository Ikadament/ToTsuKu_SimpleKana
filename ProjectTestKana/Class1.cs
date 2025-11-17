using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestKana
{
    public abstract class Kana
    {
        protected char kana;
        protected string romaji;

        public Kana(char kana, string romaji)
        {
            this.kana = kana;
            this.romaji = romaji;
        }

        public char getKana()
        {
            return this.kana;
        }

        public string getRomaji()
        {
            return this.romaji;
        }
    }

    public class Hiragana : Kana
    {
        public Hiragana(char kana, string romaji) : base(kana, romaji)
        {
            this.kana = kana;
            this.romaji = romaji;
        }
    }

    public class Katakana : Kana
    {
        public Katakana(char kana, string romaji) : base(kana, romaji)
        {
            this.kana = kana;
            this.romaji = romaji;
        }
    }
}
