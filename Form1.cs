using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{

    public partial class Form_Paint : System.Windows.Forms.Form
    {
        //変数の宣言と初期化
        Line[] line = new Line[CONST.lmax];
        bool mouseDrug = false;     
        Point[] p = new Point[CONST.pmax];
        int coordinate = 0;         //何番目の座標か
        Graphi DrawGraphi = new Graphi();
        Graphi EraseGraphi = new Graphi();
        
        
        Task TaskDraw = new Task(data.action);
        Task TaskErase = new Task(data.action);

        public Form_Paint()
        {
            InitializeComponent();

            //フォームの大きさのデフォルト値を設定
            FormSize.init();

            //線が消える秒数のデフォルト値を設定
            data.waittime = 3000;

            //ツールバーの表示設定
            data.toolbar_flg = true;

            //配列の初期化
            for (int i = 0; i < CONST.lmax; i++)
            {
                line[i] = new Line();
            }

            //PenとGraphicsの初期化
            GraphiInit();
        }

        /// <summary>
        /// Form1ロード時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //フォームの境界線をなくす
            this.FormBorderStyle = FormBorderStyle.None;

            //フォームの大きさを設定
            this.ClientSize = new Size(FormSize.width, FormSize.height);

            //透明を指定する
            //this.TransparencyKey = backcolor;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int a = 0;

            //左クリックしたとき
            if (e.Button == MouseButtons.Left)
            {
                if(data.drawcount<CONST.lmax)  //線の数が上限を達していないとき
                {
                    mouseDrug = true;

                    p[coordinate] = e.Location;

                    //一筆の一番最初だけ
                    if (a == coordinate)
                    {
                        line[data.drawcount].size = data.PenSize;     //ペンのサイズを記憶
                        line[data.drawcount].color = data.PenColor;   //ペンの色を記憶
                        DrawGraphi.pen.Color = line[data.drawcount].color;
                        DrawGraphi.pen.Width = line[data.drawcount].size;

                    }
                }
                
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                //左クリックをやめたとき
                if (e.Button == MouseButtons.Left)
                {
                    mouseDrug = false;

                    line[data.drawcount].count = coordinate;
                    line[data.drawcount].linenumber = data.drawcount;

                    data.drawcount++;

                    Eraseline();
                    coordinate = 0;
                }
            }
            catch
            {

            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            try
            {
                if (mouseDrug)
                {
                    Drawline(e);
                }

                //フォームの右上にカーソルがきたときツールバーを表示する
                if (data.toolbar_flg == true)
                {
                    if (e.Location.X > (FormSize.width * 0.9) && (e.Location.Y < (FormSize.height * 0.1)))
                    {
                        toolStrip1.Visible = true;
                    }
                    else
                    {
                        toolStrip1.Visible = false;
                    }
                }       

            }
            catch
            {

            }

        }


        #region ペンの色
        /// <summary>
        /// ペンの色を黒にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Black_Click(object sender, EventArgs e)
        {
            data.PenColor = Color.Black;
            data.brush = Brushes.Black;
        }

        /// <summary>
        /// ペンの色を赤にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Red_Click(object sender, EventArgs e)
        {
            data.PenColor = Color.Red;
            data.brush = Brushes.Red;
        }

        /// <summary>
        /// ペンの色を黄色にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Yellow_Click(object sender, EventArgs e)
        {
            data.PenColor = Color.Yellow;
            data.brush = Brushes.Yellow;
        }

        /// <summary>
        /// ペンの色を緑にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Green_Click(object sender, EventArgs e)
        {
            data.PenColor = Color.Lime;
            data.brush = Brushes.Lime;
        }

        /// <summary>
        /// ペンの色を青（透明）にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Eraser_Click(object sender, EventArgs e)
        {
            data.PenColor = Color.Blue;
            data.brush = Brushes.Blue;
        }
        #endregion

        #region ペンの太さ
        /// <summary>
        /// ペンの太さを8ptにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_8pt_Click(object sender, EventArgs e)
        {
            data.PenSize = 8;
        }

        /// <summary>
        /// ペンの太さを18ptにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_18pt_Click(object sender, EventArgs e)
        {
            data.PenSize = 18;
        }

        /// <summary>
        /// ペンの太さを28ptにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_28pt_Click(object sender, EventArgs e)
        {
            data.PenSize = 28;
        }
        #endregion

        private void toolStripButton_allClear_Click(object sender, EventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(BackColor);
            Graphics formGraphics;

            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, FormSize.width, FormSize.height));

            myBrush.Dispose();
            formGraphics.Dispose();

            data.drawcount = 0;
            data.erasecount = 0;
        }

        #region ショートカットキー

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(BackColor);
            Graphics formGraphics;

            switch (e.KeyCode)
            {
                case Keys.Right:
                    formGraphics = this.CreateGraphics();
                    formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, FormSize.width, FormSize.height));

                    myBrush.Dispose();
                    formGraphics.Dispose();

                    data.drawcount = 0;
                    data.erasecount = 0;

                    break;

                case Keys.Left:
                    formGraphics = this.CreateGraphics();
                    formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, FormSize.width, FormSize.height));

                    myBrush.Dispose();
                    formGraphics.Dispose();

                    data.drawcount = 0;
                    data.erasecount = 0;

                    break;

                case Keys.B:
                    data.PenColor = Color.Black;
                    data.brush = Brushes.Black;

                    break;

                case Keys.R:
                    data.PenColor = Color.Red;
                    data.brush = Brushes.Red;

                    break;

                case Keys.Y:
                    data.PenColor = Color.Yellow;
                    data.brush = Brushes.Yellow;

                    break;

                case Keys.G:
                    data.PenColor = Color.Lime;
                    data.brush = Brushes.Lime;

                    break;

                case Keys.Escape:
                    this.Close();

                    break;

                case Keys.D1:
                    data.PenSize = 8;

                    break;

                case Keys.D2:
                    data.PenSize = 18;

                    break;

                case Keys.D3:
                    data.PenSize = 28;

                    break;

            }

        }



        #endregion


        /// <summary>
        /// アプリを閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 右クリックメニュー

        //設定をクリックしたとき
        private void ToolStripMenuItem_Setting_Click(object sender, EventArgs e)
        {
            using (Form_Setting form2 = new Form_Setting())
            {
                form2.ShowDialog(); //設定画面を開く。設定画面が閉じるまで次のコードにいかない。


                //以下設定画面の設定を反映するコード

                //フォームの大きさを変更
                this.ClientSize = new Size(FormSize.width, FormSize.height);
                this.Refresh();

                //消しゴムの表示・非表示
                if (data.waittime!=0)
                {
                    toolStripButton_Eraser.Visible = false;
                }
                else
                {
                    toolStripButton_Eraser.Visible = true;
                }

                //線が消えるまでの時間をミリ秒に変換する
                if(data.waittime<1000)
                {
                    data.time();
                }       
                
            }
        }


        #endregion

        private void Drawline(MouseEventArgs e)
        {
            lock(line)
            {
                if(coordinate<CONST.pmax-1)
                {
                    line[data.drawcount].point[coordinate] = p[coordinate];     //線の座標(マウスが動く一つ前のe.Locationが入ってる)

                    //線を引く
                    DrawGraphi.graphics.DrawLine(DrawGraphi.pen, p[coordinate], e.Location);
                    DrawGraphi.graphics.FillEllipse(data.brush, p[coordinate].X - DrawGraphi.pen.Width / 2, p[coordinate].Y - DrawGraphi.pen.Width / 2, DrawGraphi.pen.Width, DrawGraphi.pen.Width);

                    coordinate++;

                    p[coordinate] = e.Location;
                    line[data.drawcount].point[coordinate] = p[coordinate];
                }               
            }             
        }


        private void Eraseline()
        {
            //非同期で、書いたものを消す
            Task task = Task.Factory.StartNew(() =>
            {
                try
                {
                    EraseGraphi.pen.Color = data.backcolor;
                    EraseGraphi.pen.Width = line[data.erasecount].size;


                    //線が消えるまでの時間が設定されているとき
                    if (data.waittime > 0)
                    {
                        Thread.Sleep(data.waittime);
                        for (int i = 1; i <= line[data.erasecount].count; i++)
                        {
                            EraseGraphi.graphics.DrawLine(EraseGraphi.pen, line[data.erasecount].point[i - 1], line[data.erasecount].point[i]);
                            EraseGraphi.graphics.FillEllipse(data.backbrush, line[data.erasecount].point[i - 1].X - EraseGraphi.pen.Width / 2, line[data.erasecount].point[i - 1].Y - EraseGraphi.pen.Width / 2, EraseGraphi.pen.Width, EraseGraphi.pen.Width);
                        }

                    }
                    data.erasecount++;

                }
                catch
                {

                }

            });
        }


        private void GraphiInit()
        {
            DrawGraphi.pen = new Pen(data.PenColor, data.PenSize);
            DrawGraphi.graphics = this.CreateGraphics();

            EraseGraphi.pen= new Pen(data.PenColor, data.PenSize);
            EraseGraphi.graphics = this.CreateGraphics();
        }


    }


}