using System.Text;

namespace PlayFairFix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbCzech.Checked = true;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            string input = txtInput.Text;
            string language = GetSelectedLanguage();

            string adjustedText = AdjustText(input, language);
            string[,] cipherTable = CreateTable(key, language);

            string formattedAdjustedText = FormatTextInGroups(adjustedText, 5);
            txtFiltered.Text = formattedAdjustedText;

            txtTable.Text = FormatTable(cipherTable);

            string encryptedText = Encrypt(cipherTable, adjustedText);

            if (encryptedText != null)
                encryptedText = FormatTextInGroups(encryptedText, 5);

            txtOutput.Text = encryptedText ?? "Error during encryption.";
        }



        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            string input = txtOutput.Text.Replace(" ", "");
            string language = GetSelectedLanguage();

            string[,] cipherTable = CreateTable(key, language);
            string decryptedText = Decrypt(cipherTable, input);

            txtOutput.Text = decryptedText ?? "Error during decryption.";
        }


        private string GetSelectedLanguage()
        {
            if (rbCzech.Checked)
                return "Czech";
            if (rbEnglish.Checked)
                return "English";
            return "Czech";
        }

        private string FormatTextInGroups(string text, int groupSize)
        {
            StringBuilder formattedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                formattedText.Append(text[i]);
                if ((i + 1) % groupSize == 0 && i != text.Length - 1)
                {
                    formattedText.Append(" ");
                }
            }
            return formattedText.ToString();
        }



        private string AdjustText(string text, string language)
        {
            var replacements = new Dictionary<string, string>
    {
        {"·", "a"},
        {"È", "e"},
        {"Ì", "i"},
        {"Û", "o"},
        {"˙", "u"},
        {"Ï", "e"},
        {"˘", "u"},
        {"Ë", "c"},
        {"¯", "r"},
        {"ö", "s"},
        {"ù", "t"},
        {"Ú", "n"},
        {"Ô", "d"},
        {"û", "z"},
        {"˝", "y"},
        {"0", "ZERO"},
        {"1", "ONE"},
        {"2", "TWO"},
        {"3", "THREE"},
        {"4", "FOUR"},
        {"5", "FIVE"},
        {"6", "SIKS"},
        {"7", "SEVEN"},
        {"8", "EIGHT"},
        {"9", "NINE"}
    };

            if (language == "Czech")
            {
                replacements.Add("w", "v");
            }
            else if (language == "English")
            {
                replacements.Add("q", "o");
            }

            text = text.ToLower();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (replacements.ContainsKey(c.ToString()))
                    result.Append(replacements[c.ToString()]);
                else if (char.IsLetterOrDigit(c))
                    result.Append(c);
                else if (c == ' ')
                    result.Append("XSPACEX");

                if (i < text.Length - 1 && c == text[i + 1])
                {
                    result.Append('x');
                }
            }

            if (result.Length % 2 != 0)
            {
                if (result.Length % 2 != 0)
                {
                    if (result[result.Length - 1] == 'X' || result[result.Length - 1] == 'x')
                    {
                        result.Append('N');
                    }
                    else
                    {
                        result.Append('X');
                    }
                }

            }
            return result.ToString().ToUpper();
        }

        private string[,] CreateTable(string key, string language)
        {
            string alphabet = language == "Czech" ? "ABCDEFGHIJKLMNOPQRSTUVXYZ" : "ABCDEFGHIJKLMNOPRSTUVWXYZ";
            key = AdjustKey(key, language);

            string uniqueKey = new string(key.Distinct().ToArray());
            string remainder = new string(alphabet.Except(uniqueKey).ToArray());
            string fullTable = uniqueKey + remainder;

            string[,] table = new string[5, 5];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    table[i, j] = fullTable[i * 5 + j].ToString();

            return table;
        }

        private string AdjustKey(string input, string language)
        {
            var replacements = new Dictionary<string, string>
            {
                {"·", "a"},
                {"È", "e"},
                {"Ì", "i"},
                {"Û", "o"},
                {"˙", "u"},
                {"Ï", "e"},
                {"˘", "u"},
                {"Ë", "c"},
                {"¯", "r"},
                {"ö", "s"},
                {"ù", "t"},
                {"Ú", "n"},
                {"Ô", "d"},
                {"û", "z"},
                {"˝", "y"}
            };

            input = input.ToLower();
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (replacements.ContainsKey(c.ToString()))
                    result.Append(replacements[c.ToString()]);
                else if (char.IsLetter(c))
                    result.Append(c);
            }

            string key = result.ToString().Replace(" ", "").ToUpper();
            if (language == "Czech")
                key = key.Replace("W", "V");
            else if (language == "English")
                key = key.Replace("Q", "O");

            return key;
        }

        private string Encrypt(string[,] table, string text)
        {
            var pairs = SplitIntoPairs(text);
            StringBuilder result = new StringBuilder();

            foreach (var pair in pairs)
            {
                var pos1 = FindElement(table, pair[0]);
                var pos2 = FindElement(table, pair[1]);

                if (pos1 == null || pos2 == null)
                    return null;

                int r1 = pos1[0], c1 = pos1[1], r2 = pos2[0], c2 = pos2[1];

                if (r1 == r2)
                {
                    c1 = (c1 + 1) % 5;
                    c2 = (c2 + 1) % 5;
                }
                else if (c1 == c2)
                {
                    r1 = (r1 + 1) % 5;
                    r2 = (r2 + 1) % 5;
                }
                else
                {
                    int temp = c1;
                    c1 = c2;
                    c2 = temp;
                }

                result.Append(table[r1, c1]).Append(table[r2, c2]);
            }

            return result.ToString();
        }

        private string Decrypt(string[,] table, string text)
        {
            var pairs = SplitIntoPairs(text.Replace(" ", ""));
            StringBuilder result = new StringBuilder();

            foreach (var pair in pairs)
            {
                var pos1 = FindElement(table, pair[0]);
                var pos2 = FindElement(table, pair[1]);

                if (pos1 == null || pos2 == null)
                    return null;

                int r1 = pos1[0], c1 = pos1[1], r2 = pos2[0], c2 = pos2[1];

                if (r1 == r2)
                {
                    c1 = (c1 - 1 + 5) % 5;
                    c2 = (c2 - 1 + 5) % 5;
                }
                else if (c1 == c2)
                {
                    r1 = (r1 - 1 + 5) % 5;
                    r2 = (r2 - 1 + 5) % 5;
                }
                else
                {
                    int temp = c1;
                    c1 = c2;
                    c2 = temp;
                }

                result.Append(table[r1, c1]).Append(table[r2, c2]);
            }

            string decryptedText = result.ToString()
                    .Replace("XSPACEX", " ")
                    .Replace("ZERO", "0")
                    .Replace("ONE", "1")
                    .Replace("TWO", "2")
                    .Replace("THREE", "3")
                    .Replace("FOUR", "4")
                    .Replace("FIVE", "5")
                    .Replace("SIKS", "6")
                    .Replace("SEVEN", "7")
                    .Replace("EIGHT", "8")
                    .Replace("NINE", "9");

            if (decryptedText.EndsWith("X") && !decryptedText.EndsWith("PARADOX"))
            {
                decryptedText = decryptedText.Substring(0, decryptedText.Length - 1);
            }
            return decryptedText;
        }


        private int[] FindElement(string[,] table, char c)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (table[i, j] == c.ToString())
                        return new[] { i, j };

            return null;
        }

        private List<string> SplitIntoPairs(string text)
        {
            List<string> pairs = new List<string>();
            for (int i = 0; i < text.Length; i += 2)
            {
                if (i + 1 < text.Length)
                {
                    pairs.Add(text.Substring(i, 2));
                }
                else
                {
                    pairs.Add(text.Substring(i, 1));
                }
            }
            return pairs;
        }


        private string FormatTable(string[,] table)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    result.Append(table[i, j] + " ");
                result.AppendLine();
            }
            return result.ToString();
        }
    }
}
