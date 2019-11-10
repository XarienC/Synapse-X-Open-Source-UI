using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using sxlib;
using sxlib.Specialized;
using System.IO;

namespace OpenSourceUI
{
    public partial class ExecutingTab : UserControl
    {
        public ExecutingTab()
        {
            InitializeComponent();
            InitNumberMargin();

            #region Scintilla
            Scintilla scintilla = this.ExecutingBox;
            foreach (Style style in scintilla.Styles)
            {
                style.Font = "Monaco";
                style.ForeColor = IntToColor(0xFFFFFF);
                style.Size = 11;

                scintilla.Styles[32].BackColor = Color.FromArgb(40, 40, 40);
                scintilla.StyleClearAll();
                scintilla.Styles[33].BackColor = Color.FromArgb(40, 40, 40);
                scintilla.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xFFFFFF);
                scintilla.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0x558817);
                scintilla.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x558817);
                scintilla.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
                scintilla.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xE94744);
                scintilla.Styles[Style.Cpp.String].ForeColor = IntToColor(0xE94744);
                scintilla.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
                scintilla.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
                scintilla.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
                scintilla.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
                scintilla.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
                scintilla.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x01A9E9);
                scintilla.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0x01A9E9);
                scintilla.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
                scintilla.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
                scintilla.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);
                scintilla.Lexer = Lexer.Cpp;

                scintilla.Styles[14].Bold = true;
                scintilla.SetKeywords(0, "and break do else elseif end for function if in local nil not or repeat return then until while false truefor local end nil next _G debug do repeat until string math function");
                scintilla.SetKeywords(1, "string.byte string.char string.dump string.find string.format string.gsub string.len string.lower string.rep string.sub string.upper table.concat table.insert table.remove table.sort math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.deg math.exp math.floor math.frexp math.ldexp math.log math.max math.min math.pi math.pow math.rad math.random math.randomseed math.sin math.sqrt math.tan string.gfind string.gmatch string.match string.reverse string.pack string.packsize string.unpack table.foreach table.foreachi table.getn table.setn table.maxn table.pack table.unpack table.move math.cosh math.fmod math.huge math.log10 math.modf math.mod math.sinh math.tanh math.maxinteger math.mininteger math.tointeger math.type math.ult bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bit32.rrotate bit32.rshift utf8.char utf8.charpattern utf8.codes utf8.codepoint utf8.len utf8.offsetassert collectgarbage dofile error _G getmetatable ipairs loadfile next pairs pcall print rawequal rawget rawset setmetatable tonumber tostring type _VERSION xpcall string table math coroutine io os debug getfenv gcinfo load loadlib loadstring require select setfenv unpack _LOADED LUA_PATH _REQUIREDNAME package rawlen package bit32 utf8 _ENV loadstring setmetatable wait tostring tonumber pairs getsenv getlocals getfenv setfenv print getrawmetatable getmetatable setreadonly getreg getlocal require");
                scintilla.SetKeywords(2, "game syn writefile decompile Drawing");
            }
            #endregion
        }

        #region Utilities
        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }
        public void InvokeIfNeeded(Action action)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(action);
            }
            else
            {
                action.Invoke();
            }
        }
        #endregion

        #region Numbers, Margins, Code Folding
        /// the background color of the text area
        private const int BACK_COLOR = 0x2D2D2D;

        /// default text color of the text area
        private const int FORE_COLOR = 0x2D2D2D;

        /// change this to whatever margin you want the line numbers to show in
        private const int NUMBER_MARGIN = 1;

        /// change this to whatever margin you want the bookmarks/breakpoints to show in
        private const int BOOKMARK_MARGIN = 2;
        private const int BOOKMARK_MARKER = 2;

        /// change this to whatever margin you want the code folding tree (+/-) to show in
        private const int FOLDING_MARGIN = 3;

        /// set this true to show circular buttons for code folding (the [+] and [-] buttons on the margin)
        private const bool CODEFOLDING_CIRCULAR = true;

        private void InitNumberMargin()
        {

            ExecutingBox.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            ExecutingBox.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            ExecutingBox.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            ExecutingBox.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = ExecutingBox.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;

            ExecutingBox.MarginClick += ExecutingBox_MarginClick;
        }

        private void InitBookmarkMargin()
        {

            //ExecutingBox.SetFoldMarginColor(true, IntToColor(BACK_COLOR));

            var margin = ExecutingBox.Margins[BOOKMARK_MARGIN];
            margin.Width = 20;
            margin.Sensitive = true;
            margin.Type = MarginType.Symbol;
            margin.Mask = (1 << BOOKMARK_MARKER);
            //margin.Cursor = MarginCursor.Arrow;

            var marker = ExecutingBox.Markers[BOOKMARK_MARKER];
            marker.Symbol = MarkerSymbol.Circle;
            marker.SetBackColor(IntToColor(0xFF003B));
            marker.SetForeColor(IntToColor(0x000000));
            marker.SetAlpha(100);

        }

        private void InitCodeFolding()
        {

            ExecutingBox.SetFoldMarginColor(true, IntToColor(BACK_COLOR));
            ExecutingBox.SetFoldMarginHighlightColor(true, IntToColor(BACK_COLOR));

            // Enable code folding
            ExecutingBox.SetProperty("fold", "1");
            ExecutingBox.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            ExecutingBox.Margins[FOLDING_MARGIN].Type = MarginType.Symbol;
            ExecutingBox.Margins[FOLDING_MARGIN].Mask = Marker.MaskFolders;
            ExecutingBox.Margins[FOLDING_MARGIN].Sensitive = true;
            ExecutingBox.Margins[FOLDING_MARGIN].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                ExecutingBox.Markers[i].SetForeColor(IntToColor(BACK_COLOR)); // styles for [+] and [-]
                ExecutingBox.Markers[i].SetBackColor(IntToColor(FORE_COLOR)); // styles for [+] and [-]
            }

            // Configure folding markers with respective symbols
            ExecutingBox.Markers[Marker.Folder].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlus : MarkerSymbol.BoxPlus;
            ExecutingBox.Markers[Marker.FolderOpen].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinus : MarkerSymbol.BoxMinus;
            ExecutingBox.Markers[Marker.FolderEnd].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlusConnected : MarkerSymbol.BoxPlusConnected;
            ExecutingBox.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            ExecutingBox.Markers[Marker.FolderOpenMid].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinusConnected : MarkerSymbol.BoxMinusConnected;
            ExecutingBox.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            ExecutingBox.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            ExecutingBox.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

        }
        private void ExecutingBox_MarginClick(object sender, MarginClickEventArgs e) //Only used for Margins
        {

        }

        #endregion

        #region Buttons
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            string script = this.ExecutingBox.Text;
            Functions.Lib.Execute(script);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ExecutingBox.Text = "";
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (Functions.OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.ExecutingBox.Text = File.ReadAllText(Functions.OpenFile.FileName);
                }
                catch (Exception Error)
                {
                    MessageBox.Show("Error loading script!" + Error.Message);
                }
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            SaveFile.Filter = "Text Files (*.txt)|*.txt|Lua Files (*lua*)|*.lua";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(this.SaveFile.FileName, this.ExecutingBox.Text);
            }
        }

        private void ExecuteFileButton_Click(object sender, EventArgs e)
        {
            if (Functions.ExecuteDialog.ShowDialog() == DialogResult.OK)
            {
                Functions.Lib.Execute(File.ReadAllText(Functions.ExecuteDialog.FileName));
            }
        }
        #endregion
    }
}
