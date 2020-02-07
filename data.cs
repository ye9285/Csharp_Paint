//Form間共通の変数を宣言する場所

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
    //線が消える時間を格納する変数
    public static class data
    {
        //デフォルト値
        public static int waittime;                 //線が消えるまでの秒数
        public static bool toolbar_flg;

        public static int PenSize = 18;                 //ペンのサイズ
        public static Color PenColor = Color.Black;     //ペンの色
        public static Brush brush = Brushes.Black;      //ペンの色
        public static Color backcolor = Color.Blue;     //背景色
        public static Brush backbrush = Brushes.Blue;   //背景色

        public static int drawcount = 0;        //何本目の線を描いてるか
        public static int erasecount = 0;       //何本目の線を消してるか

        

        /// <summary>
        /// 入力された整数値をミリ秒単位に変換
        /// </summary>
        public static void time()
        {
            waittime = waittime * 1000;
        }

        public static Action action = () => { };
    }

    public static class CONST
    {
        public const int pmax = 5000;    //一筆で書ける座標数の上限
        public const int lmax = 1000;    //描写できる線の上限数。→または←キーを押すとリセットされる。
    }
    

    //フォームのサイズを格納する
    public static class FormSize
    {
        public static int width;
        public static int height;

        public static void init()
        {
            width = 1024;
            height = 768;
        }
    }

    //描いた線の情報を格納する
    public class Line
    {
        public int size;     //ペンのサイズ
        public Color color;  //ペンの色
        public Point[] point = new Point[CONST.pmax];   //線の座標を格納する配列
        public int count;                               //上の配列のどこまで値が入っているかを覚えておく変数
        public int linenumber;                          //何本目の線か      
    }

    public class Graphi
    {
        public Pen pen;
        public Graphics graphics;
    }
}
