using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Entity
{
    public class Car
    {
        public int speed;
        public void DrawRoad(Graphics g)
        {
            Pen p = new Pen(Color.MediumAquamarine, 5);
            Pen p0 = new Pen(Color.MistyRose, 5);
            Pen p01 = new Pen(Color.Gray, 8);
            Pen p02 = new Pen(Color.Black, 8);
            //tree1
            g.DrawLine(p01, new Point(20, 50), new Point(20, 30));
           // g.FillEllipse(Brushes.Green, 20, 25, 50, 50);//divi1
            g.FillEllipse(Brushes.Green, 15, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 0, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 20, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 10, 10, 15, 10);
            //tree2
            g.DrawLine(p01, new Point(80, 50), new Point(80, 30));
            //g.FillEllipse(Brushes.Green, 80, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 80, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 60, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 70, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 70, 10, 15, 10);
            //tree3
            g.DrawLine(p01, new Point(140, 50), new Point(140, 30));
            //g.FillEllipse(Brushes.Green, 150, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 140, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 130, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 120, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 130, 10, 15, 10);
            //tree4
            g.DrawLine(p01, new Point(200, 50), new Point(200, 30));
           // g.FillEllipse(Brushes.Green, 200, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 200, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 190, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 180, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 190, 10, 15, 10);

            g.DrawLine(p01, new Point(260, 50), new Point(260, 30));
            g.FillEllipse(Brushes.Green, 260, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 250, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 240, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 250, 10, 15, 10);

            g.DrawLine(p01, new Point(320, 50), new Point(320, 30));
            g.FillEllipse(Brushes.Green, 320, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 310, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 300, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 310, 10, 15, 10);

            g.DrawLine(p01, new Point(380, 50), new Point(380, 30));
            g.FillEllipse(Brushes.Green, 380, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 370, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 360, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 370, 10, 15, 10)
                ;
            g.DrawLine(p01, new Point(440, 50), new Point(440, 30));
            g.FillEllipse(Brushes.Green, 440, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 430, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 420, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 430, 10, 15, 10);


            g.DrawLine(p01, new Point(900, 50), new Point(900, 30));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 900, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 890, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 880, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 890, 10, 15, 10);

            


            g.DrawLine(p01, new Point(950, 50), new Point(950, 30));
           // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 950, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 940, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 930, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green,940, 10, 15, 10);

            g.DrawLine(p01, new Point(1000, 50), new Point(1000, 30));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 1000, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 990, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 980, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 990, 10, 15, 10);

            g.DrawLine(p01, new Point(1050, 50), new Point(1050, 30));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 1050, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 1040, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 1030, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 1040, 10, 15, 10);

            g.DrawLine(p01, new Point(1100, 50), new Point(1100, 30));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 1100, 20, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 1090, 20, 15, 10);//1
            g.FillEllipse(Brushes.Green, 1080, 20, 15, 10);//3
            g.FillEllipse(Brushes.Green, 1090, 10, 15, 10);


            g.DrawLine(p01, new Point(50, 430), new Point(50, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 50, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 40, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 30, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 40, 415, 15, 10);

            g.DrawLine(p01, new Point(100, 430), new Point(100, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 100, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 90, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 80, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 90, 415, 15, 10);

            g.DrawLine(p01, new Point(150, 430), new Point(150, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 150, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 140, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 130, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 140, 415, 15, 10);

            g.DrawLine(p01, new Point(200, 430), new Point(200, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 200, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 190, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 180, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 190, 415, 15, 10);

            g.DrawLine(p01, new Point(250, 430), new Point(250, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 250, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 240, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 230, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 240, 415, 15, 10);

            g.DrawLine(p01, new Point(300, 430), new Point(300, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 300, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 290, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 280, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 290, 415, 15, 10);//3

            g.DrawLine(p01, new Point(350, 430), new Point(350, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 350, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 340, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 330, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 340, 415, 15, 10);//3

            g.DrawLine(p01, new Point(400, 430), new Point(400, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 400, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 390, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 380, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 390, 415, 15, 10);//3

            g.DrawLine(p01, new Point(450, 430), new Point(450, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 450, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 440, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 430, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 440, 415, 15, 10);//3

            g.DrawLine(p01, new Point(500, 430), new Point(500, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 500, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 490, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 480, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 490, 415, 15, 10);//3

            g.DrawLine(p01, new Point(550, 430), new Point(550, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 550, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 540, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 530, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 540, 415, 15, 10);//3

            g.DrawLine(p01, new Point(600, 430), new Point(600, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 600, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 590, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 580, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 590, 415, 15, 10);//3

            g.DrawLine(p01, new Point(650, 430), new Point(650, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 650, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 640, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 630, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 640, 415, 15, 10);//3


            g.DrawLine(p01, new Point(700, 430), new Point(700, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 700, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 690, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 680, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 690, 415, 15, 10);//3

            g.DrawLine(p01, new Point(750, 430), new Point(750, 460));
            // g.FillEllipse(Brushes.Green, 90, 30, 50, 50);//divi2
            g.FillEllipse(Brushes.Green, 750, 425, 15, 10);//tree2
            g.FillEllipse(Brushes.Green, 740, 425, 15, 10);//1
            g.FillEllipse(Brushes.Green, 730, 425, 15, 10);//3
            g.FillEllipse(Brushes.Green, 740, 415, 15, 10);//3
            







        }
        public void DrawCar(Graphics G, int objId)
        {
            Pen p = new Pen(Color.DeepSkyBlue, 5);
            Pen p01 = new Pen(Color.DeepSkyBlue, 5);
            if (objId == 0)
            {
                G.DrawLine(p, new Point(35, 40), new Point(35, 90));//a,b
                G.DrawLine(p, new Point(35, 40), new Point(75, 40));//a,c
                G.DrawLine(p, new Point(75, 40), new Point(100, 10));//c,d
                G.DrawLine(p, new Point(100, 10), new Point(200, 10));//d,e
                G.DrawLine(p, new Point(200, 10), new Point(230, 40));//e,f
                G.DrawLine(p, new Point(35, 90), new Point(75, 90));
                G.DrawLine(p, new Point(100, 90), new Point(200, 90));

                G.DrawLine(p, new Point(230, 40), new Point(270, 40));//f,g
                G.DrawLine(p, new Point(270, 40), new Point(270, 90));//g,h
                G.DrawLine(p, new Point(270, 90), new Point(250, 90));
                G.FillRectangle(Brushes.Red, 260, 50, 18, 18);

                G.DrawEllipse(p, 75, 70, 40, 40);
                G.DrawEllipse(p, 190, 70, 40, 40);
                G.DrawLine(p, new Point(75, 90), new Point(100, 90));
                G.DrawLine(p, new Point(95, 70), new Point(95, 110));

                G.DrawLine(p, new Point(200, 90), new Point(250, 90));
                G.DrawLine(p, new Point(210, 70), new Point(210, 110));

                G.DrawLine(p, new Point(75, 40), new Point(230, 40));
                G.DrawLine(p, new Point(100, 10), new Point(100, 40));
                G.DrawLine(p, new Point(200, 10), new Point(200, 40));
              

            }
            if (objId == 1)
            {
              /*  g.DrawRectangle(p, 40, 30, 80, 60);
                g.DrawLine(p, new Point(120, 32), new Point(100, 40));
                g.DrawLine(p, new Point(100, 40), new Point(100, 70));
                g.DrawLine(p, new Point(100, 70), new Point(120, 90));
                g.DrawRectangle(p, 60, 42, 40, 35);
                g.DrawLine(p, new Point(60, 42), new Point(40, 30));
                g.DrawLine(p, new Point(60, 75), new Point(40, 90));

                g.DrawLine(p, new Point(40, 30), new Point(1, 40));
                g.DrawLine(p, new Point(1, 40), new Point(1, 77));
                g.DrawLine(p, new Point(1, 77), new Point(40, 90));*/
                G.DrawLine(p, new Point(35, 40), new Point(35, 90));//a,b
                G.DrawLine(p, new Point(35, 40), new Point(75, 40));//a,c
                G.DrawLine(p, new Point(75, 40), new Point(100, 10));//c,d
                G.DrawLine(p, new Point(100, 10), new Point(200, 10));//d,e
                G.DrawLine(p, new Point(200, 10), new Point(230, 40));//e,f
                G.DrawLine(p, new Point(35, 90), new Point(75, 90));
                G.DrawLine(p, new Point(100, 90), new Point(200, 90));

                G.DrawLine(p, new Point(230, 40), new Point(270, 40));//f,g
                G.DrawLine(p, new Point(270, 40), new Point(270, 90));//g,h
                G.DrawLine(p, new Point(270, 90), new Point(250, 90));
                G.FillRectangle(Brushes.Red, 25, 50, 18, 18);

                G.DrawEllipse(p, 75, 70, 40, 40);
                G.DrawEllipse(p, 190, 70, 40, 40);
                G.DrawLine(p, new Point(75, 90), new Point(100, 90));
                G.DrawLine(p, new Point(95, 70), new Point(95, 110));

                G.DrawLine(p, new Point(200, 90), new Point(250, 90));
                G.DrawLine(p, new Point(210, 70), new Point(210, 110));

                G.DrawLine(p, new Point(75, 40), new Point(230, 40));
                G.DrawLine(p, new Point(100, 10), new Point(100, 40));
                G.DrawLine(p, new Point(200, 10), new Point(200, 40));
              
            
               

            }
            if (objId == 2)
            {
                G.DrawLine(p01, new Point(100,210), new Point(190, 210));
                G.DrawLine(p01, new Point(100, 210), new Point(100, 50));
                G.DrawLine(p01, new Point(100, 50), new Point(120, 20));
                G.DrawLine(p01, new Point(120, 20), new Point(170, 20));
                G.DrawLine(p01, new Point(170, 20), new Point(190, 50));
                G.DrawLine(p01, new Point(190, 210), new Point(190, 50));
                Point[] p1 = { new Point(100, 50), new Point(150, 40), new Point(190, 50) };
                G.DrawCurve(p01, p1);
                G.DrawLine(p01, new Point(100, 50), new Point(130, 70));
                G.DrawLine(p01, new Point(130, 70), new Point(130, 180));
                G.DrawLine(p01, new Point(130, 180), new Point(100, 210));
                G.DrawLine(p01, new Point(190, 50), new Point(160, 70));
                G.DrawLine(p01, new Point(160, 70), new Point(160, 180));
                G.DrawLine(p01, new Point(160, 180), new Point(190, 210));
                G.DrawLine(p01, new Point(130, 70), new Point(160, 70));
                G.DrawLine(p01, new Point(130, 180), new Point(160, 180));

                G.FillRectangle(Brushes.Red, 130, 5, 20, 20);
                //G.FillRectangle(Brushes.Red, 160, 20, 10, 10);
               
               
               
               
               
               
               


            }
            if (objId == 3)
            {
                G.DrawLine(p01, new Point(100, 50), new Point(190, 50));

                Point[] p1 = { new Point(100, 210), new Point(150, 218), new Point(190, 210) };
                G.DrawCurve(p01, p1);
                G.DrawLine(p01, new Point(100, 210), new Point(120, 240));
                G.DrawLine(p01, new Point(120, 240), new Point(170, 240));
                G.DrawLine(p01, new Point(170, 240), new Point(190, 210));


                G.DrawLine(p01, new Point(100, 210), new Point(100, 50));
                G.DrawLine(p01, new Point(190, 210), new Point(190, 50));
                G.DrawLine(p01, new Point(100, 50), new Point(130, 70));
                G.DrawLine(p01, new Point(130, 70), new Point(130, 180));
                G.DrawLine(p01, new Point(130, 180), new Point(100, 210));
                G.DrawLine(p01, new Point(190, 50), new Point(160, 70));
                G.DrawLine(p01, new Point(160, 70), new Point(160, 180));
                G.DrawLine(p01, new Point(160, 180), new Point(190, 210));
                G.DrawLine(p01, new Point(130, 70), new Point(160, 70));
                G.DrawLine(p01, new Point(130, 180), new Point(160, 180));
                G.FillRectangle(Brushes.Red, 140, 230, 20, 20);
                


            }
            
        }
    }
}
