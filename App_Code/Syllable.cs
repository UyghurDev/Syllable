using System;
using System.Collections.Generic;
using System.Text;


namespace net.UyghurDev.Text
{
    /// <summary>
    /// ئۇيغۇرچە بوغۇم ئايرىش
    /// <para>ئۇيغۇر يۇمشاق دېتال ئىجادىيەت تورى</para>
    /// </summary>
    public class Syllable
    {
        public Syllable()
        {
            
        }

        /// <summary>
        /// بوغۇم ئايرىش
        /// </summary>
        /// <param name="Word"></param>
        /// <returns></returns>
        public string[] getSyllable(string Word)
        {
            Dictionary<int, int> dicVowelPosition = new Dictionary<int, int>();
            Dictionary<int,string> dicSyllables = new Dictionary<int,string>();

            int nPositionIndex = 0;
            string tems = Word;
            string temso = Word;
            int nWordLength = Word.Length;
            if ((nWordLength > 0x31) || (nWordLength < 2))
            {
                dicSyllables.Clear();
            }
            for (int i = 0; i <= (nWordLength - 1); i++)
            {
                char chrOne = tems.Substring(0, 1).ToCharArray()[0];
                tems = Word.Substring(i + 1, nWordLength - (i + 1));
                if (isVowel(chrOne))
                {
                    nPositionIndex++;
                    dicVowelPosition.Add(nPositionIndex, i);
                    if (nPositionIndex > 1)
                    {
                        switch ((dicVowelPosition[nPositionIndex] - dicVowelPosition[nPositionIndex - 1]))
                        {
                            case 2:
                                dicSyllables.Add(nPositionIndex - 1, temso.Substring(0, 2));
                                temso = temso.Substring(2, temso.Length - dicSyllables[nPositionIndex - 1].Length);
                                break;

                            case 3:
                                dicSyllables.Add(nPositionIndex - 1, temso.Substring(0, 3));
                                temso = temso.Substring(3, temso.Length - dicSyllables[nPositionIndex - 1].Length);
                                break;

                            case 4:
                                dicSyllables.Add(nPositionIndex - 1, temso.Substring(0, 4));
                                temso = temso.Substring(4, temso.Length - dicSyllables[nPositionIndex - 1].Length);
                                break;
                        }
                    }
                }
            }
            dicSyllables.Add(nPositionIndex, temso);
            if (((nPositionIndex == 1) && !isOneSyllable(Word)) || !isOneSyllable(temso))
            {
                dicSyllables.Clear();
            }
            string[] straRet = new string[dicSyllables.Count];
            for (int nCount = 1; nCount < dicSyllables.Count+1; nCount++)
            {
                straRet[nCount-1] = dicSyllables[nCount];
            }
            return straRet;
        }

        /// <summary>
        /// سۇزۇق تاۋۇشمۇ؟
        /// </summary>
        /// <param name="chr">بىر ھەرىپ</param>
        /// <returns>راست يالغان تىپ</returns>
        private bool isVowel(char chr)
        {


            if ((((chr != 0x627) && (chr != 0x648)) && ((chr != 0x649) && (chr != 0x6d0))) && (((chr != 0x6d5) && (chr != 0x6c6)) && ((chr != 0x6c7) && (chr != 0x6c8))))
            {
                return false;
            }
            return true;

        }

        /// <summary>
        /// ئۈزۈك تاۋۇۋشمۇ؟
        /// </summary>
        /// <param name="chr">بىر ھەرىپ</param>
        /// <returns>راست يالغان تىپ</returns>
        private bool isConsonant(char chr)
        {

            int asci = chr;
            if ((((((asci != 0x67e) && (asci != 0x62a)) && ((asci != 0x686) && (asci != 0x62e))) && (((asci != 0x633) && (asci != 0x634)) && ((asci != 0x641) && (asci != 0x642)))) && ((((asci != 0x643) && (asci != 0x6be)) && ((asci != 0x628) && (asci != 0x62f))) && (((asci != 0x631) && (asci != 0x632)) && ((asci != 0x698) && (asci != 0x62c))))) && ((((asci != 0x63a) && (asci != 0x6af)) && ((asci != 0x6ad) && (asci != 0x644))) && (((asci != 0x645) && (asci != 0x646)) && ((asci != 0x6cb) && (asci != 0x64a)))))
            {
                return false;
            }
            return true;

        }

        /// <summary>
        /// بىر بۇغۇملۇق سۆزمۇ؟
        /// </summary>
        /// <param name="Word">بىر سۆز</param>
        /// <returns></returns>
        private bool isOneSyllable(string Word)
        {
            string strWord = Word;
            int nLength = Word.Length;
            if ((nLength > 4) || (nLength < 2))
            {
                return false;
            }
            for (int i = 1; i <= nLength; i++)
            {
                string strOne = strWord.Substring(0, 1);
                char chr = strOne.ToCharArray()[0];
                strWord = strWord.Substring(1, strWord.Length - 1);
                if ((i == 2) && isConsonant(chr))
                {
                    return false;
                }
                if ((i != 2) && isVowel(chr))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
