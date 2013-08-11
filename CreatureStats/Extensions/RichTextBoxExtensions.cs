﻿using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Windows.Forms;

namespace CreatureStats.Extensions
{
    public static class RichTextBoxExtensions
    {
        public const String DefaultFamily = "Arial Unicode MS";
        public const float DefaultSize = 9.0f;

        public static void AppendFormatLine(this RichTextBox textbox, string format, params object[] arg0)
        {
            Contract.Requires(format != null);
            Contract.Requires(arg0 != null);
            textbox.AppendText(String.Format(format, arg0) + Environment.NewLine);
            SetDefaultStyle(textbox);
        }

        public static void AppendFormat(this RichTextBox textbox, string format, params object[] arg0)
        {
            Contract.Requires(format != null);
            Contract.Requires(arg0 != null);
            textbox.AppendText(String.Format(format, arg0));
            SetDefaultStyle(textbox);
        }

        public static void AppendLine(this RichTextBox textbox)
        {
            textbox.AppendText(Environment.NewLine);
        }

        public static void AppendLine(this RichTextBox textbox, string text)
        {
            textbox.AppendText(text + Environment.NewLine);
        }

        public static void Append(this RichTextBox textbox, object text)
        {
            textbox.AppendText(text.ToString());
        }

        public static void AppendFormatLineIfNotNull(this RichTextBox builder, string format, uint arg)
        {
            Contract.Requires(format != null);
            if (arg != 0)
                builder.AppendFormatLine(format, arg);
        }

        public static void AppendFormatLineIfNotNull(this RichTextBox builder, string format, float arg)
        {
            Contract.Requires(format != null);
            if (arg != 0.0f)
                builder.AppendFormatLine(format, arg);
        }

        public static void AppendFormatLineIfNotNull(this RichTextBox builder, string format, string arg)
        {
            Contract.Requires(format != null);
            if (arg != String.Empty)
                builder.AppendFormatLine(format, arg);
        }

        public static void AppendFormatIfNotNull(this RichTextBox builder, string format, uint arg)
        {
            Contract.Requires(format != null);
            if (arg != 0)
                builder.AppendFormat(format, arg);
        }

        public static void AppendFormatIfNotNull(this RichTextBox builder, string format, float arg)
        {
            Contract.Requires(format != null);
            if (arg != 0.0f)
                builder.AppendFormat(format, arg);
        }

        public static void AppendFormatIfNotNull(this RichTextBox builder, string format, string arg)
        {
            Contract.Requires(format != null);
            if (arg != String.Empty)
                builder.AppendFormat(format, arg);
        }

        public static void SetStyle(this RichTextBox textbox, Color color, FontStyle style)
        {
            textbox.SelectionColor = color;
            textbox.SelectionFont = new Font(DefaultFamily, DefaultSize, style);
        }

        public static void SetBold(this RichTextBox textbox)
        {
            textbox.SelectionFont = new Font(DefaultFamily, DefaultSize, FontStyle.Bold);
        }

        public static void SetBoldWithDefault(this RichTextBox textbox)
        {
            SetDefaultStyle(textbox);
            SetBold(textbox);
        }

        public static void SetDefaultStyle(this RichTextBox textbox)
        {
            textbox.SelectionFont = new Font(DefaultFamily, DefaultSize, FontStyle.Regular);
            textbox.SelectionColor = Color.Black;
        }

        public static void ColorizeCode(this RichTextBox rtb)
        {
            string[] keywords = { "INSERT", "INTO", "DELETE", "FROM", "IN", "VALUES", "WHERE" };
            var text = rtb.Text;

            rtb.SelectAll();
            rtb.SelectionColor = rtb.ForeColor;

            foreach (var keyword in keywords)
            {
                var keywordPos = rtb.Find(keyword, RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord);

                while (keywordPos != -1)
                {
                    var commentPos = text.LastIndexOf("-- ", keywordPos, StringComparison.OrdinalIgnoreCase);
                    var newLinePos = text.LastIndexOf("\n", keywordPos, StringComparison.OrdinalIgnoreCase);

                    var quoteCount = 0;
                    var quotePos = text.IndexOf("\"", newLinePos + 1, keywordPos - newLinePos, StringComparison.OrdinalIgnoreCase);

                    for (; quotePos != -1; quoteCount++)
                    {
                        quotePos = text.IndexOf("\"", quotePos + 1, keywordPos - (quotePos + 1), StringComparison.OrdinalIgnoreCase);
                    }

                    if (newLinePos >= commentPos && quoteCount % 2 == 0)
                        rtb.SelectionColor = Color.Blue;
                    else if (newLinePos == commentPos)
                        rtb.SelectionColor = Color.Green;

                    keywordPos = rtb.Find(keyword, keywordPos + rtb.SelectionLength, RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord);
                }
            }

            rtb.Select(0, 0);
        }
    }
}
