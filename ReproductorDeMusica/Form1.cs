using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace ReproductorDeMusica
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer player;
        private DoubleLinkedList songList;

        public Form1()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            songList = new DoubleLinkedList();
            lstvSongs.View = View.List;
        }

        private void btnLoadSongs_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string[] archivos = Directory.GetFiles(folderDialog.SelectedPath, "*.mp3");
                foreach (string archivo in archivos)
                {
                    string nombre = Path.GetFileName(archivo);
                    songList.AggNode(nombre, archivo);
                    lstvSongs.Items.Add(nombre);
                }
                songList.Inicializar();
            }
        }

        private bool isPlaying = false;
        private bool isPaused = false;

        private void BtnPlay(object sender, EventArgs e)
        {
            if (songList.Current != null)
            {
                if (isPlaying)
                {
                    player.controls.pause();
                    btnPlay.Text = "▶";
                    lblSongName.Text = songList.Current.Name;
                    isPaused = true;
                }
                else
                {
                    if (!isPaused)
                    {
                        player.URL = songList.Current.Rute;
                    }
                    player.controls.play();
                    btnPlay.Text = "⏸︎";
                    lblSongName.Text = songList.Current.Name;
                    isPaused = false;
                }
                isPlaying = !isPlaying;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (songList.Current != null && songList.Current.Prev != null)
            {
                songList.Current = songList.Current.Prev;
                player.URL = songList.Current.Rute;
                player.controls.play();
                lblSongName.Text = songList.Current.Name;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (songList.Current != null && songList.Current.Next != null)
            {
                songList.Current = songList.Current.Next;
                player.URL = songList.Current.Rute;
                player.controls.play();
                lblSongName.Text = songList.Current.Name;
            }
        }
    }
}
