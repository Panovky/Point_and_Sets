using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Discretka_2.Form1;

namespace Discretka_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Figure
        {
            public int type = 1; // 1 - прямоугольник (по умолчанию), 2 - круг
            public double x, y;  // координаты центра фигуры
            public double radius;
            public double width;
            public double heigth;

            // метод для определения принадлежности (непринадлежности) точки к фигуре
            // в метод передаются координаты точки
            public bool checkBelonging(double x0, double y0) 
            {
                if (type == 1) // для прямоугольника
                {
                    if (x + width / 2 >= x0 && x0 >= x - width / 2 && y - heigth / 2 <= y0 && y0 <= y + heigth / 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else // для круга
                {
                    if ((x - x0) * (x - x0) + (y - y0) * (y - y0) <= radius * radius)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        // событие по нажатию кнопки "Очистить"
        private void clear_Click(object sender, EventArgs e)
        {
            // по умолчанию везде устанавливаются прямоугольники
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            radioButton6.Checked = true;
            radioButton8.Checked = true;

            // поля координат центров всех фигур очищаются
            Ax.Text = ""; Ay.Text = "";
            Bx.Text = ""; By.Text = "";
            Cx.Text = ""; Cy.Text = "";
            Dx.Text = ""; Dy.Text = "";

            // поля радиусов всех фигур очищаются
            Aradius.Text = "";
            Bradius.Text = "";
            Cradius.Text = "";
            Dradius.Text = "";

            // поля ширины и высоты всех фигур очищаются
            Awidth.Text = ""; Aheigth.Text = "";
            Bwidth.Text = ""; Bheigth.Text = "";
            Cwidth.Text = ""; Cheigth.Text = "";
            Dwidth.Text = ""; Dheigth.Text = "";

            // надпись "Радиус" для всех фигур скрывается
            // поля для радиусов для всех фигур очищаются
            labelRadiusA.Visible = false; Aradius.Visible = false;
            labelRadiusB.Visible = false; Bradius.Visible = false;
            labelRadiusC.Visible = false; Cradius.Visible = false;
            labelRadiusD.Visible = false; Dradius.Visible = false;

            // надпись "Ширина" для всех фигур отображается
            // поля для ширины для всех фигур отображаются
            labelWidthA.Visible = true; Awidth.Visible = true;
            labelWidthB.Visible = true; Bwidth.Visible = true;
            labelWidthC.Visible = true; Cwidth.Visible = true;
            labelWidthD.Visible = true; Dwidth.Visible = true;

            // надпись "Высота" для всех фигур отображается
            // поля для высоты для всех фигур отображаются
            labelHeigthA.Visible = true; Aheigth.Visible = true;
            labelHeigthB.Visible = true; Bheigth.Visible = true;
            labelHeigthC.Visible = true; Cheigth.Visible = true;
            labelHeigthD.Visible = true; Dheigth.Visible = true;

            // поля для координат точки очищаются
            Tx.Text = ""; Ty.Text = "";

            // надписи с ответом скрываются
            AnswerNo.Visible = false; AnswerYes.Visible = false;
        }

        // событие при изменении типа фигуры А
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) // если выбран прямоугольник для фигуры А
            {
                labelRadiusA.Visible = false; Aradius.Visible = false;
                labelWidthA.Visible = true; Awidth.Visible = true;
                labelHeigthA.Visible = true; Aheigth.Visible = true;
            }
            else // если выбран круг для фигуры А
            {
                labelRadiusA.Visible = true; Aradius.Visible = true;
                labelWidthA.Visible = false; Awidth.Visible = false;
                labelHeigthA.Visible = false; Aheigth.Visible = false;
            }
        }

        // событие при изменении типа фигуры В
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) // если выбран прямоугольник для фигуры В
            {
                labelRadiusB.Visible = false; Bradius.Visible = false;
                labelWidthB.Visible = true; Bwidth.Visible = true;
                labelHeigthB.Visible = true; Bheigth.Visible = true;
            }
            else // если выбран круг для фигуры B
            {
                labelRadiusB.Visible = true; Bradius.Visible = true;
                labelWidthB.Visible = false; Bwidth.Visible = false;
                labelHeigthB.Visible = false; Bheigth.Visible = false;
            }
        }

        // событие при изменении типа фигуры С
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true) // если выбран прямоугольник для фигуры С
            {
                labelRadiusC.Visible = false; Cradius.Visible = false;
                labelWidthC.Visible = true; Cwidth.Visible = true;
                labelHeigthC.Visible = true; Cheigth.Visible = true;
            }
            else // если выбран круг для фигуры C
            {
                labelRadiusC.Visible = true; Cradius.Visible = true;
                labelWidthC.Visible = false; Cwidth.Visible = false;
                labelHeigthC.Visible = false; Cheigth.Visible = false;
            }
        }

        // событие при изменении типа фигуры D
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true) // если выбран прямоугольник для фигуры D
            {
                labelRadiusD.Visible = false; Dradius.Visible = false;
                labelWidthD.Visible = true; Dwidth.Visible = true;
                labelHeigthD.Visible = true; Dheigth.Visible = true;
            }
            else // если выбран круг для фигуры D
            {
                labelRadiusD.Visible = true; Dradius.Visible = true;
                labelWidthD.Visible = false; Dwidth.Visible = false;
                labelHeigthD.Visible = false; Dheigth.Visible = false;
            }
        }

        // событие при нажатии кнопки "Проверить"
        private void check_Click(object sender, EventArgs e)
        {
            double tx, ty; // координаты точки
            tx = Convert.ToDouble(Tx.Text);
            ty = Convert.ToDouble(Ty.Text);

            Figure figureA = new Figure();
            figureA.x = Convert.ToDouble(Ax.Text);
            figureA.y = Convert.ToDouble(Ay.Text);
            if (radioButton1.Checked == true)
            {
                figureA.width = Convert.ToDouble(Awidth.Text);
                figureA.heigth = Convert.ToDouble(Aheigth.Text);
            }
            else
            {
                figureA.type = 2;
                figureA.radius = Convert.ToDouble(Aradius.Text);
            }

            Figure figureB = new Figure();
            figureB.x = Convert.ToDouble(Bx.Text);
            figureB.y = Convert.ToDouble(By.Text);
            if (radioButton4.Checked == true)
            {
                figureB.width = Convert.ToDouble(Bwidth.Text);
                figureB.heigth = Convert.ToDouble(Bheigth.Text);
            }
            else
            {
                figureB.type = 2;
                figureB.radius = Convert.ToDouble(Bradius.Text);
            }

            Figure figureC = new Figure();
            figureC.x = Convert.ToDouble(Cx.Text);
            figureC.y = Convert.ToDouble(Cy.Text);
            if (radioButton6.Checked == true)
            {
                figureC.width = Convert.ToDouble(Cwidth.Text);
                figureC.heigth = Convert.ToDouble(Cheigth.Text);
            }
            else
            {
                figureC.type = 2;
                figureC.radius = Convert.ToDouble(Cradius.Text);
            }

            Figure figureD = new Figure();
            figureD.x = Convert.ToDouble(Dx.Text);
            figureD.y = Convert.ToDouble(Dy.Text);
            if (radioButton8.Checked == true)
            {
                figureD.width = Convert.ToDouble(Dwidth.Text);
                figureD.heigth = Convert.ToDouble(Dheigth.Text);
            }
            else
            {
                figureD.type = 2;
                figureD.radius = Convert.ToDouble(Dradius.Text);
            }

            bool A, B, C, D, result;
            A = figureA.checkBelonging(tx, ty);
            B = figureB.checkBelonging(tx, ty);
            C = figureC.checkBelonging(tx, ty);
            D = figureD.checkBelonging(tx, ty);
            result = (!A && (B || C)) || D;

            if (result)
            {
                AnswerNo.Visible = false;
                AnswerYes.Visible = true;
            }
            else
            {
                AnswerYes.Visible = false;
                AnswerNo.Visible = true;
            }
        }
    }
}
