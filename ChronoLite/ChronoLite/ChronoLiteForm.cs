using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChronoLite
{
    public partial class MainForm : Form
    {
        private bool isSettingsOpen = false;
        private Timer timer;
        private DateTime startTime;
        private TimeSpan elapsedTime;
        private TimeSpan intervalTime;
        private TimeSpan intervalCounter;

        public MainForm()
        {
            InitializeComponent();
            InitializeTimer();
            TranslateButtonNames();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = DateTime.Now - startTime;

            string formattedTime;
            if (elapsedTime.TotalHours >= 1)
            {
                formattedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    (int)elapsedTime.TotalHours,
                    elapsedTime.Minutes,
                    elapsedTime.Seconds,
                    elapsedTime.Milliseconds / 10);
            }
            else
            {
                formattedTime = String.Format("{0:00}:{1:00}.{2:00}",
                    elapsedTime.Minutes,
                    elapsedTime.Seconds,
                    elapsedTime.Milliseconds / 10);
            }

            MainTime.Text = formattedTime;

            intervalCounter = elapsedTime - intervalTime;

            string formattedIntervalTime;
            if (intervalCounter.TotalHours >= 1)
            {
                formattedIntervalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    (int)intervalCounter.TotalHours,
                    intervalCounter.Minutes,
                    intervalCounter.Seconds,
                    intervalCounter.Milliseconds / 10);
            }
            else
            {
                formattedIntervalTime = String.Format("{0:00}:{1:00}.{2:00}",
                    intervalCounter.Minutes,
                    intervalCounter.Seconds,
                    intervalCounter.Milliseconds / 10);
            }

            IntervalTime.Text = formattedIntervalTime;
        }

        private void TranslateButtonNames()
        {
            string currentCulture = System.Globalization.CultureInfo.CurrentCulture.Name;

            switch (currentCulture)
            {
                case "ru-RU":
                    buttonStop.Text = "Стоп";
                    buttonClearTime.Text = "Отчистить";
                    buttonStart.Text = "Начать";
                    buttonPlay.Text = "Продолж.";
                    buttonInterval.Text = "Интервал";
                    break;

                case "en-US":
                    buttonStop.Text = "Stop";
                    buttonClearTime.Text = "Clear";
                    buttonStart.Text = "Start";
                    buttonPlay.Text = "Play";
                    buttonInterval.Text = "Interval";
                    break;

                case "fr-FR":
                    buttonStop.Text = "Arrêter";
                    buttonClearTime.Text = "Effacer";
                    buttonStart.Text = "Démarrer";
                    buttonPlay.Text = "Jouer";
                    buttonInterval.Text = "Intervalle";
                    break;

                case "es-ES":
                    buttonStop.Text = "Detener";
                    buttonClearTime.Text = "Limpiar";
                    buttonStart.Text = "Iniciar";
                    buttonPlay.Text = "Reproducir";
                    buttonInterval.Text = "Intervalo";
                    break;

                case "de-DE":
                    buttonStop.Text = "Stop";
                    buttonClearTime.Text = "Löschen";
                    buttonStart.Text = "Start";
                    buttonPlay.Text = "Abspielen";
                    buttonInterval.Text = "Intervall";
                    break;

                case "it-IT":
                    buttonStop.Text = "Stop";
                    buttonClearTime.Text = "Pulisci";
                    buttonStart.Text = "Avvia";
                    buttonPlay.Text = "Riproduci";
                    buttonInterval.Text = "Intervallo";
                    break;

                case "pt-BR":
                    buttonStop.Text = "Parar";
                    buttonClearTime.Text = "Limpar";
                    buttonStart.Text = "Iniciar";
                    buttonPlay.Text = "Reproduzir";
                    buttonInterval.Text = "Intervalo";
                    break;

                case "zh-CN":
                    buttonStop.Text = "停止";
                    buttonClearTime.Text = "清除";
                    buttonStart.Text = "开始";
                    buttonPlay.Text = "播放";
                    buttonInterval.Text = "间隔";
                    break;

                case "ja-JP":
                    buttonStop.Text = "停止";
                    buttonClearTime.Text = "クリア";
                    buttonStart.Text = "開始";
                    buttonPlay.Text = "再生";
                    buttonInterval.Text = "インターバル";
                    break;

                case "ko-KR":
                    buttonStop.Text = "정지";
                    buttonClearTime.Text = "지우기";
                    buttonStart.Text = "시작";
                    buttonPlay.Text = "재생";
                    buttonInterval.Text = "간격";
                    break;

                case "ar-SA":
                    buttonStop.Text = "توقف";
                    buttonClearTime.Text = "مسح";
                    buttonStart.Text = "بدء";
                    buttonPlay.Text = "تشغيل";
                    buttonInterval.Text = "فاصل زمني";
                    break;

                case "tr-TR":
                    buttonStop.Text = "Durdur";
                    buttonClearTime.Text = "Temizle";
                    buttonStart.Text = "Başlat";
                    buttonPlay.Text = "Oynat";
                    buttonInterval.Text = "Aralık";
                    break;

                case "nl-NL":
                    buttonStop.Text = "Stop";
                    buttonClearTime.Text = "Wissen";
                    buttonStart.Text = "Start";
                    buttonPlay.Text = "Afspelen";
                    buttonInterval.Text = "Interval";
                    break;

                case "sv-SE":
                    buttonStop.Text = "Stoppa";
                    buttonClearTime.Text = "Rensa";
                    buttonStart.Text = "Starta";
                    buttonPlay.Text = "Spela";
                    buttonInterval.Text = "Intervall";
                    break;

                case "pl-PL":
                    buttonStop.Text = "Stop";
                    buttonClearTime.Text = "Wyczyść";
                    buttonStart.Text = "Start";
                    buttonPlay.Text = "Odtwórz";
                    buttonInterval.Text = "Interwał";
                    break;


                default:
                    buttonStop.Text = "Stop";
                    buttonClearTime.Text = "Clear";
                    buttonStart.Text = "Start";
                    buttonPlay.Text = "Play";
                    buttonInterval.Text = "Interval";
                    break;
            }
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            buttonInterval.Visible = true;
            buttonStop.Visible = true;

            startTime = DateTime.Now - elapsedTime;
            timer.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStop.Visible = false;
            buttonInterval.Visible = false;

            buttonPlay.Visible = true;
            buttonClearTime.Visible = true;

            timer.Stop();
        }

        private void buttonInterval_Click(object sender, EventArgs e)
        {
            IntervalTime.Visible = true;

            intervalTime = elapsedTime;

            string formattedIntervalTime;
            if (intervalTime.TotalHours >= 1)
            {
                formattedIntervalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    (int)intervalTime.TotalHours,
                    intervalTime.Minutes,
                    intervalTime.Seconds,
                    intervalTime.Milliseconds / 10);
            }
            else
            {
                formattedIntervalTime = String.Format("{0:00}:{1:00}.{2:00}",
                    intervalTime.Minutes,
                    intervalTime.Seconds,
                    intervalTime.Milliseconds / 10);
            }

            IntervalTime.Text = formattedIntervalTime;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonStop.Visible = true;
            buttonInterval.Visible = true;

            buttonPlay.Visible = false;
            buttonClearTime.Visible = false;

            startTime = DateTime.Now - elapsedTime;
            timer.Start();
        }

        private void buttonClearTime_Click(object sender, EventArgs e)
        {
            buttonStop.Visible = false;
            buttonInterval.Visible = false;
            buttonPlay.Visible = false;
            buttonClearTime.Visible = false;
            IntervalTime.Visible = false;
            IntervalTime.Visible = false;

            buttonStart.Visible = true;

            MainTime.Text = "00:00.0";
            elapsedTime = TimeSpan.Zero;
            intervalTime = TimeSpan.Zero;
            intervalCounter = TimeSpan.Zero;
        }

        private void SettingsAndBack_Click(object sender, EventArgs e)
        {
            if (isSettingsOpen)
            {
                this.Size = new Size(237, 223);

                SettingsAndBack.Image = Properties.Resources.setting1s;
            }
            else
            {
                this.Size = new Size(365, 223);

                SettingsAndBack.Image = Properties.Resources.back;
            }

            isSettingsOpen = !isSettingsOpen;
        }
        private void toggletopmost_CheckedChanged_1(object sender, EventArgs e)
        {
            this.TopMost = toggletopmost.Checked;
        }
    }
}
