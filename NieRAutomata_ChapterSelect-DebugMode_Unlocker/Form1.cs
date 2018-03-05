using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NieRAutomata_ChapterSelect_DebugMode_Unlocker
{
    public partial class Form1 : Form
    {
        /* REMEMBER LITTLE-ENDIAN! */
        private enum Flag
        {
            None = 0x00, // 0000 0000
            Unknown1 = 0x01, // 0000 0001
            Unknown2 = 0x02, // 0000 0010
            ChapterSelectAndDebugRoom = 0x04, // 0000 0100
            DebugMenu = 0x08, // 0000 1000
            Unused1 = 0x16, // 0001 0000
            Unused2 = 0x32, // 0010 0000
            Unused3 = 0x64, // 0100 0000
            Unused4 = 0x128, // 1000 0000
        }

        private string _filePath = null;
        private static int _intBlockOffset = 234775;
        private Flag _enumFlags = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenSlot_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Yes;

            if (_filePath != null)
            {
                dialogResult = MessageBox.Show("You already have a file opened. Opening another will discard all unsaved changes.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }

            if (dialogResult == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\NieR_Automata",
                    Filter = "Save File (SlotData_#.dat)|SlotData_*.dat",
                    Title = "Open slot file"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filePath = openFileDialog.FileName;
                    textBoxFilePath.Text = _filePath;
                    textBoxFilePath.SelectionStart = textBoxFilePath.Text.Length;

                    // Read the file
                    using (Stream stream = openFileDialog.OpenFile())
                    {
                        stream.Position = _intBlockOffset;
                        _enumFlags = (Flag)stream.ReadByte();
                    }

#if DEBUG
                    Console.WriteLine("Read: " + _enumFlags);
#endif

                    // Populate the checkboxes based on the flags
                    cbUnknown1.Checked = _enumFlags.HasFlag(Flag.Unknown1);
                    cbUnknown2.Checked = _enumFlags.HasFlag(Flag.Unknown2);
                    cbDebugMode.Checked = _enumFlags.HasFlag(Flag.DebugMenu);
                    cbChapterSelectDebugRoom.Checked = _enumFlags.HasFlag(Flag.ChapterSelectAndDebugRoom);

                    // Enable the GUI
                    buttonSave.Enabled = true;
                    cbUnknown1.Enabled = true;
                    cbUnknown2.Enabled = true;
                    cbChapterSelectDebugRoom.Enabled = true;
                    cbDebugMode.Enabled = true;
                }
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save your changes to the slot file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {

                _enumFlags = cbDebugMode.Checked ? _enumFlags | Flag.DebugMenu : _enumFlags & ~Flag.DebugMenu;
                _enumFlags = cbChapterSelectDebugRoom.Checked ? _enumFlags | Flag.ChapterSelectAndDebugRoom : _enumFlags & ~Flag.ChapterSelectAndDebugRoom;
                _enumFlags = cbUnknown1.Checked ? _enumFlags | Flag.Unknown1 : _enumFlags & ~Flag.Unknown1;
                _enumFlags = cbUnknown2.Checked ? _enumFlags | Flag.Unknown2 : _enumFlags & ~Flag.Unknown2;

#if DEBUG
                Console.WriteLine("Wrote: " + Enum.Parse(typeof(Flag), _enumFlags.ToString()));
#endif

                // Create a backup first
                File.Copy(_filePath, _filePath + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss.bak"));

                // Now overwrite the data
                using (Stream stream = File.Open(_filePath, FileMode.Open, FileAccess.Write))
                {
                    stream.Position = _intBlockOffset;
                    stream.WriteByte((byte)_enumFlags);
                }

                MessageBox.Show("Changes were saved!", "Save complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
