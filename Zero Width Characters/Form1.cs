using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zero_Width_Characters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Encrypt(string priv, string pub)
        {
            // Grab the public message string and break it up into characters
            String[] PubMsg = pub.Split();

            // Find the half-way point in the string
            decimal length = pub.Length / 2;
            int half = Convert.ToInt32(Math.Round(length, 0, MidpointRounding.AwayFromZero));
            // Grab the private message
            string PrivMsg = priv;

            // Convert it to binary data
            PrivMsg = str2bin(str2byte(PrivMsg, Encoding.UTF8));

            // And convert that into a string of zero-width characters
            PrivMsg = bin2hidden(PrivMsg);

            // Finally, wrap it with a distinct boundary character
            PrivMsg = wrap(PrivMsg);

            // Inject the encoded private message into the approximate half-way point in the public string
            int i = 0;
            int v = 1;
            List<string> Tmp = new List<string>();
            List<char> Temp = new List<char>();
            if (PubMsg.Length == 1)
            {
                Tmp.Add(PubMsg[0]);
                Tmp.Add(PrivMsg);
            }
            else
            {
                v = 0;
                foreach (char c in String.Join(" ", PubMsg))
                {
                    if (i == half)
                    {
                        Temp.AddRange(PrivMsg.ToCharArray());
                    }
                    Temp.Add(c);
                    i++;
                }
            }
            if (v == 1)
            {
                PubMsg = Tmp.ToArray();
            }
            else
            {
                string[] t = new[] { String.Concat(Temp) };
                PubMsg = t;
            }

            // Display the public message with the hidden private message embedded
            return String.Concat(PubMsg);
        }

        static string Decrypt(string pub)
        {
            // Unhide the message
            string unwrapped = unwrap(pub);
            string message = "";
            // If it's not wrapped, process the full string as received
            if (unwrapped == "false")
            {
                message = bin2str(hidden2bin(pub));
            }
            // Otherwise, process only the unwrapped string
            else
            {
                message = bin2str(hidden2bin(unwrapped));
            }

            // Display the hidden private message
            if (message.Length < 2)
            {
                return "No private message was found in that text.";
            }
            else
            {
                return message;
            }
        }

        //Convert a String to a byte array
        public static byte[] str2byte(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }

        //Convert a string to binary data
        public static string str2bin(Byte[] text)
        {
            return string.Join(" ", text.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

        // Wrap a string with a distinct boundary
        public static string wrap(string text)
        {
            return $"\uFEFF{text}\uFEFF"; // Unicode Character 'ZERO WIDTH NON-BREAKING SPACE' (U+FEFF) 0xEF 0xBB 0xBF
        }

        // Unwrap a string if the distinct boundary exists
        public static string unwrap(string text)
        {
            String[] Tmp = text.Split("\uFEFF".ToCharArray());
            if (Tmp.Length == 1) { return "false"; }
            return Tmp[1];
        }

        // Convert binary data into a string
        public static string bin2str(string bin)
        {
            bin = Regex.Replace(bin, "[^0-1]", " ");
            String[] text = new string[] { };
            List<Byte> va = new List<Byte>();
            foreach(int vw in Enumerable.Range(0, bin.Split().Length))
            {
                va.Add(Convert.ToByte(Regex.Replace(bin.Split()[vw], @"\s", ""), 2));
            }
            return Encoding.UTF8.GetString(va.ToArray());
        }

        // Convert the ones, zeros, and spaces of the hidden binary data to their respective zero-width characters 
        public static string bin2hidden(string text)
        {
            text = text.Replace(" ", "\u2060"); // Unicode Character 'WORD JOINER' (U+2060) 0xE2 0x81 0xA0
            text = text.Replace("0", "\u200B"); // Unicode Character 'ZERO WIDTH SPACE' (U+200B) 0xE2 0x80 0x8B
            text = text.Replace("1", "\u200C"); // Unicode Character 'ZERO WIDTH NON-JOINER' (U+200C) 0xE2 0x80 0x8C
            return text;
        }

        // Convert zero-width characters to hidden binary data
        public static string hidden2bin(string text)
        {
            text = text.Replace("\u2060", " "); // Unicode Character 'WORD JOINER' (U+2060) 0xE2 0x81 0xA0
            text = text.Replace("\u200B", "0"); // Unicode Character 'ZERO WIDTH SPACE' (U+200B) 0xE2 0x80 0x8B
            text = text.Replace("\u200C", "1"); // Unicode Character 'ZERO WIDTH NON-JOINER' (U+200C) 0xE2 0x80 0x8C
            return text;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            // Display the public message with the hidden private message embedded
            StegOut.Text = Encrypt(PrivateMessageInput.Text, PublicMessageInput.Text);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            // Display the private message hidden in the public message
            RevealMsg.Text = Decrypt(PubMsgDecode.Text);
        }

        private void PublicMessageInput_TextChanged(object sender, EventArgs e)
        {
            if (RTEncode.Checked)
            {
                if (PrivateMessageInput.TextLength != 0)
                {
                    StegOut.Text = Encrypt(PrivateMessageInput.Text, PublicMessageInput.Text);
                }
            }
        }

        private void PrivateMessageInput_TextChanged(object sender, EventArgs e)
        {
            if (RTEncode.Checked)
            {
                if (PublicMessageInput.TextLength != 0)
                {
                    StegOut.Text = Encrypt(PrivateMessageInput.Text, PublicMessageInput.Text);
                }
            }
        }
    }
}
