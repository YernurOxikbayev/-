using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p;
        string s = "";

        //-----------------------------------------------------------------------------1
        private void YesRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Зерна имеют криволинейные формы?"; // 1
            panel2.Enabled = true;
            p1 = 1;
        }

        private void YesNoRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Зерна имеют криволинейные формы?"; // 1
            panel2.Enabled = true;
            p1 = 0.7;
        }   

        private void NoYesRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Твердость по шкале Мооса находится в пределах 1 – 3?"; // 25
            panel2.Enabled = true;
            p1 = 0.3;
        }

        private void NoRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Твердость по шкале Мооса находится в пределах 1 – 3?"; //25
            panel2.Enabled = true;
            p1 = 0;
        }
        //-----------------------------------------------------------------------------1

        //-----------------------------------------------------------------------------2
        private void YesRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            p2 = 1;
            panel3.Enabled = true;

            if (p1 > 0.5)
                label3.Text = "Выступающие углы и ребра сглажены?"; // 16
            else
                label3.Text = "Зерна имеют ветвистые формы?"; // 26
        }

        private void YesNoRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            p2 = 0.7;
            panel3.Enabled = true;

            if (p1 > 0.5)
                label3.Text = "Выступающие углы и ребра сглажены?"; // 16
            else
                label3.Text = "Зерна имеют ветвистые формы?"; // 26
        }

        private void NoRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            p2 = 0;
            panel3.Enabled = true;

            if (p1 < 0.5)
                label3.Text = "Порода похожа на кремнистую?"; // 28
            else
                label3.Text = "Зерна имеют ветвистую форму?"; // 2
        }

        private void NoYesRradioButton2_CheckedChanged(object sender, EventArgs e)
        {
            p2 = 0.3;
            panel3.Enabled = true;

            if (p1 < 0.5)
                label3.Text = "Порода похожа на кремнистую?"; // 28
            else
                label3.Text = "Зерна имеют ветвистую форму?"; // 2
        }
        //-----------------------------------------------------------------------------2

        //-----------------------------------------------------------------------------3
        private void YesRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            p3 = 1;
            

            if (p1 > 0.5 && p2 > 0.5)
            {
                panel4.Enabled = true;
                label4.Text = "Структура породы - рыхлая?"; // 17
            }
                    
            else if (p1 > 0.5 && p2 < 0.5)
            {
                panel4.Enabled = true;
                label4.Text = "Текстура породы однородная, слоистая?"; // 22
            }
                    
            else if (p1 < 0.5 && p2 > 0.5)
            {
                p = (p1 + p2 + p3) / 3;
                if (p >= 0.47 && p < 0.545)
                    s = "Глина";
                else if (p >= 0.545 && p < 0.62)
                    s = "Акриллит";
                else if (p >= 0.62 && p < 0.695)
                    s = "Глинистый сланец";
                else
                    s = "Филлит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);// Вывод результата Глина, Акриллит, Глинистый сланец, Филлит
            }
                    
            else
            {
                p = (p1 + p2 + p3) / 3;
                if (p > 0.23 && p <= 0.33)
                    s = "Опока";
                else if (p > 0.33 && p <= 0.43)
                    s = "Яшма";
                else
                    s = "Микрокварцит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);// Вывод результата Опока, Яшма, Микрокварцит
            }
                    
        }

        private void YesNoRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            p3 = 1;
            
            if (p1 > 0.5 && p2 > 0.5)                    
            {
                panel4.Enabled = true;
                label4.Text = "Структура породы - рыхлая?"; // 17
            }

            else if (p1 > 0.5 && p2 < 0.5)
            {
                panel4.Enabled = true;
                label4.Text = "Текстура породы однородная, слоистая?"; // 22
            }
                    
            else if (p1 < 0.5 && p2 > 0.5)
            {
                string s;
                double p = (p1 + p2 + p3) / 3;
                if (p <= 0.25)
                    s = "Глина";
                else if (p > 0.25 && p <= 0.5)
                    s = "Акриллит";
                else if (p > 0.5 && p <= 0.75)
                    s = "Глинистый сланец";
                else
                    s = "Филлит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);// Вывод результата Глина, Акриллит, Глинистый сланец, Филлит
            }
                
            else
            {
                p = (p1 + p2 + p3) / 3;
                if (p > 0.23 && p <= 0.33)
                    s = "Опока";
                else if (p > 0.33 && p <= 0.43)
                    s = "Яшма";
                else
                    s = "Микрокварцит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);// Вывод результата Опока, Яшма, Микрокварцит
            }
                    
        }

        private void NoYesRradioButton3_CheckedChanged(object sender, EventArgs e)
        {
            p3 = 0.3;
            panel4.Enabled = true;

            if (p1 < 0.5 && p2 < 0.5)
                    label4.Text = "Порода - вулканическая?"; // 29
            else if (p1 < 0.5 && p2 > 0.5)
                    label4.Text = "Порода похожа на карбонатную?"; // 27
            else if (p1 > 0.5 && p2 < 0.5)
                    label4.Text = "Текстура породы однородная?"; // 3
            else
                    label4.Text = "Текстура породы рыхлая?"; // 17
        }

        private void NoRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            p3 = 0;
            panel4.Enabled = true;

            if (p1 < 0.5 && p2 < 0.5)
                label4.Text = "Порода - вулканическая?"; // 29
            else if (p1 < 0.5 && p2 > 0.5)
                label4.Text = "Порода похожа на карбонатную?"; // 27
            else if (p1 > 0.5 && p2 < 0.5)
                label4.Text = "Текстура породы однородная?"; // 3
            else
                label4.Text = "Текстура породы рыхлая?"; // 17
        }
        //-----------------------------------------------------------------------------3

        //-----------------------------------------------------------------------------4
        private void YesRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            p4 = 1;
            panel5.Enabled = true;

            if (p1 > 0.5 && p2 > 0.5)
            
                label5.Text = "Размер зёрен больше 100 мм?"; // 18
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5)
                {
                    panel5.Enabled = false;
                    s = "Ракушняк";
                    MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5)
                    label5.Text = "Содержание диоксида кремния в пределах 64-78%?"; // 6
                else if (p1 < 0.5 && p2 > 0.5 && p3 < 0.5)
                {
                    panel5.Enabled = false;
                    p = (p1 + p2 + p3 + p4) / 4;
                    if (p >= 1.4 && p < 1.7)
                        s = "Мел";
                    else if (p >= 1.7 && p < 2)
                        s = "Мергель";
                    else if (p >= 2 && p < 2.3)
                        s = "Известняк";
                    else
                        s = "Доломитит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 == 0 && p2 == 0 && p3 == 0)
            {
                    panel5.Enabled = false;
                    p = (p1 + p2 + p3 + p4) / 4;
                    if (p >= 0.7 && p < 1.1)
                        s = "Талькит";
                    else if (p >= 1.1 && p < 1.5)
                        s = "Серпентинит";
                    else
                        s = "Роговик";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void YesNoRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            p4 = 0.7;
            panel5.Enabled = true;

            if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5)
                label5.Text = "Размер зёрен больше 100 мм?"; // 18
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5)
                label5.Text = "Размер зёрен больше 100 мм?"; // 18
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5)
            {
                panel5.Enabled = false;
                s = "Ракушняк";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }  
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5)
                label5.Text = "Содержание диоксида кремния в пределах 64-78%?"; // 6
            else if (p1 < 0.5 && p2 > 0.5 && p3 < 0.5)
            {
                panel5.Enabled = false;
                p = (p1 + p2 + p3 + p4) / 4;
                if (p >= 1.4 && p < 1.7)
                    s = "Мел";
                else if (p >= 1.7 && p < 2)
                    s = "Мергель";
                else if (p >= 2 && p < 2.3)
                    s = "Известняк";
                else
                    s = "Доломитит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if(p1 < 0.5 && p2 < 0.5 && p3 < 0.5)
            {
                panel5.Enabled = false;
                p = (p1 + p2 + p3 + p4) / 4;
                if (p >= 0.7 && p < 1.1)
                    s = "Талькит";
                else if (p >= 1.1 && p < 1.5)
                    s = "Серпентинит";
                else
                    s = "Роговик";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void NoYesRradioButton4_CheckedChanged(object sender, EventArgs e)
        {
            p4 = 0.3;
            panel5.Enabled = true;

            if (p1 < 0.5 && p2 < 0.5 && p3 < 0.5)
            {
                panel5.Enabled = false;
                p = (p1 + p2 + p3 + p4) / 4;
                if (p >= 0.7 && p < 1)
                    s = "Базальт";
                else if (p >= 1 && p < 1.3)
                    s = "Андезит";
                else if (p >= 1.3 && p < 1.6)
                    s = "Риолит";
                else
                    s = "Обсидан";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 < 0.5 && p2 > 0.5 && p3 < 0.5)
            {
                panel5.Enabled = false;
                p = (p1 + p2 + p3 + p4) / 4;
                if (p >= 0.7 && p < 1.1)
                    s = "Гипсит";
                else if (p >= 1.1 && p < 1.5)
                    s = "Каменная соль";
                else
                    s = "Сильвинит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5)
                label5.Text = "Отдельность породы – сложная?"; // 4
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5)
                label5.Text = "Текстура имеет сотовые формы?"; // 23
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5)
                label5.Text = "Размер зёрен больше 100 мм?"; // 18
            else
                label5.Text = "Размер зёрен больше 100 мм?"; // 18
        }

        private void NoRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            p4 = 0;
            panel5.Enabled = true;

            if (p1 < 0.5 && p2 < 0.5 && p3 < 0.5)
            {
                panel5.Enabled = false;
                p = (p1 + p2 + p3 + p4) / 4;
                if (p >= 0.7 && p < 1)
                    s = "Базальт";
                else if (p >= 1 && p < 1.3)
                    s = "Андезит";
                else if (p >= 1.3 && p < 1.6)
                    s = "Риолит";
                else
                    s = "Обсидан";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 < 0.5 && p2 > 0.5 && p3 < 0.5)
            {
                panel5.Enabled = false;
                p = (p1 + p2 + p3 + p4) / 4;
                if (p >= 0.7 && p < 1.1)
                    s = "Гипсит";
                else if (p >= 1.1 && p < 1.5)
                    s = "Каменная соль";
                else
                    s = "Сильвинит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5)
                label5.Text = "Отдельность породы – сложная?"; // 4
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5)
                label5.Text = "Текстура имеет сотовые формы?"; // 23
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5)
                label5.Text = "Размер зёрен больше 100 мм?"; // 18
            else
                label5.Text = "Размер зёрен больше 100 мм?"; // 18
        }
        //-----------------------------------------------------------------------------4

        //-----------------------------------------------------------------------------5
        private void YesRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            p5 = 1;

            if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 > 0.5)
            {
                s = "Валунник";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 < 0.5)
            {
                s = "Валунный конгломерат";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 > 0.5)
            {
                s = "Глыбовая россыпь";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 < 0.5)
            {
                s = "Глыбовая брекчия";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5 && p4 < 0.5)
            {
                s = "Коралловый известняк";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5)
            {
                panel6.Enabled = true;
                label6.Text = "Структура породы – неполнокристаллическая?"; // 9
            }
               
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5) / 5;
                if (p >= 1.4 && p < 1.775)
                    s = "Кальцитит";
                else if (p >= 1.775 && p < 2.15)
                    s = "Кварцитит";
                else if (p >= 2.15 && p < 2.525)
                    s = "Флюоритит";
                else
                    s = "Эпидотит";
            }
        }

        private void YesNoRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            p5 = 0.7;

            if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 > 0.5)
            {
                s = "Валунник";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 < 0.5)
            {
                s = "Валунный конгломерат";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 > 0.5)
            {
                s = "Глыбовая россыпь";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 < 0.5)
            {
                s = "Глыбовая брекчия";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5 && p4 < 0.5)
            {
                s = "Коралловый известняк";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5)
            {
                panel6.Enabled = true;
                label6.Text = "Структура породы – неполнокристаллическая?"; // 9
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5) / 5;
                if (p >= 1.4 && p < 1.775)
                    s = "Кальцитит";
                else if (p >= 1.775 && p < 2.15)
                    s = "Кварцитит";
                else if (p >= 2.15 && p < 2.525)
                    s = "Флюоритит";
                else
                    s = "Эпидотит";
            }
        }

        private void NoYesRradioButton5_CheckedChanged(object sender, EventArgs e)
        {
            p5 = 0.3;
            panel6.Enabled = true;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5)
                label6.Text = "Отдельность – клетчатая или отсутсвующая?"; // 5
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5)
                label6.Text = "Содержание диоксида кремния в пределах 53-64%?"; // 7
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5 && p4 < 0.5)
                label6.Text = "Текстура – неяснослоистая и полурыхлая?"; // 24
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 < 0.5)
                label6.Text = "Размер зёрен находится в пределах 10 - 100 мм?"; // 19
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 > 0.5)
                label6.Text = "Размер зёрен находится в пределах 10 - 100 мм?"; // 19
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 < 0.5)
                label6.Text = "Размер зёрен находится в пределах 10 - 100 мм?"; // 19
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 > 0.5)
                label6.Text = "Размер зёрен находится в пределах 10 - 100 мм?"; // 19

        }

        private void NoRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            p5 = 0;
            panel6.Enabled = true;     

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5)
                label6.Text = "Отдельность – клетчатая или отсутсвующая?"; // 5
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5)
                label6.Text = "Содержание диоксида кремния в пределах 53-64%?"; // 7
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5 && p4 < 0.5)
                label6.Text = "Текстура – неяснослоистая и полурыхлая?"; // 24
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 < 0.5)
                label6.Text = "Размер зёрен находится в пределах 10 - 100 мм?"; // 19
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 > 0.5)
                label6.Text = "Размер зёрен находится в пределах 10 - 100 мм?"; // 19
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 < 0.5)
                label6.Text = "Размер зёрен находится в пределах 10 - 100 мм?"; // 19
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 > 0.5)
                label6.Text = "Размер зёрен находится в пределах 10 - 100 мм?"; // 19
        }
        //-----------------------------------------------------------------------------5

        //-----------------------------------------------------------------------------6
        private void YesRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            p6 = 1;
            
            if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 > 0.5 && p5 < 0.5)
            {
                s = "Галечник";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 < 0.5 && p5 < 0.5)
            {
                s = "Конгломерат";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5)
            {
                s = "Щебень";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5)
            {
                s = "Брекчия";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5 && p4 < 0.5 && p5 < 0.5)
            {
                s = "Торф";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 > 0.5)
            {
                s = "Гранит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5)
            {
                panel7.Enabled = true;
                label7.Text = "Структура породы – неполнокристаллическая?"; // 9
            }
                
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6) / 6;
                if (p >= 1.4 && p < 2)
                    s = "Гипсит";
                else if (p >= 2 && p < 2.6)
                    s = "Сильвинит";
                else
                    s = "Каменная соль";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void YesNoRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            p6 = 0.7;
            
            if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 > 0.5 && p5 < 0.5)
            {
                s = "Галечник";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 < 0.5 && p5 < 0.5)
            {
                s = "Конгломерат";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5)
            {
                s = "Щебень";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5)
            {
                s = "Брекчия";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5 && p4 < 0.5 && p5 < 0.5)
            {
                s = "Торф";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 > 0.5)
            {
                s = "Гранит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5)
            {
                panel7.Enabled = true;
                label7.Text = "Структура породы – неполнокристаллическая?"; // 9
            }
                
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6) / 6;
                if (p >= 1.4 && p < 2)
                    s = "Гипсит";
                else if (p >= 2 && p < 2.6)
                    s = "Сильвинит";
                else
                    s = "Каменная соль";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void NoYesRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            p6 = 0.3;
            panel7.Enabled = true;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5)
                label7.Text = "Структура характеризуется наличием изогнутых зерен?"; // 10
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5)
                label7.Text = "Содержание диоксида кремния в пределах 45-53%?"; // 8
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 > 0.5)
            {
                panel7.Enabled = false;
                s = "Риолит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5 && p4 < 0.5 && p5 < 0.5)
            {
                panel7.Enabled = false;
                s = "Порода с растительными остатками";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p5 < 0.5)
                label7.Text = "Размер зёрен находится в пределах 1 - 10 мм?"; // 20
        }

        private void NoRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            p6 = 0;
            panel7.Enabled = true;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5)
                label7.Text = "Структура характеризуется наличием изогнутых зерен?"; // 10
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5)
                label7.Text = "Содержание диоксида кремния в пределах 45-53%?"; // 8
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 > 0.5)
            {
                panel7.Enabled = false;
                s = "Риолит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 > 0.5 && p4 < 0.5 && p5 < 0.5)
            {
                panel7.Enabled = false;
                s = "Порода с растительными остатками";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p5 < 0.5)
                label7.Text = "Размер зёрен находится в пределах 1 - 10 мм?"; // 20
        }
        //-----------------------------------------------------------------------------6

        //-----------------------------------------------------------------------------7
        private void YesRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            p7 = 1;

            if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                s = "Гравий";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                s = "Гравелит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                s = "Дресва";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                s = "Мелкообломочная брекчия";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 > 0.5)
            {
                s = "Сиенит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                panel8.Enabled = true;
                label8.Text = "Структура данной породы – неполнокристаллическая?"; // 9
            }
                
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                s = "Обломки и перетертая часть обломочных пород";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void YesNoRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            p7 = 0.7;

            if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                s = "Гравий";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                s = "Гравелит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                s = "Дресва";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                s = "Мелкообломочная брекчия";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 > 0.5)
            {
                s = "Сиенит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                panel8.Enabled = true;
                label8.Text = "Структура данной породы – неполнокристаллическая?"; // 9
            }
                
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
            {
                s = "Обломки и перетертая часть обломочных пород";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void NoYesRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            p7 = 0.3;
            panel8.Enabled = true;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Структура характеризуется преобладанием чешуйчатых металлов?"; // 11
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Структура – неполнокристаллическая?"; // 9
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 > 0.5)
            {
                panel8.Enabled = false;
                s = "Трахит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Размер зёрен в пределах 0,1 - 1 мм?"; // 21
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Размер зёрен в пределах 0,1 - 1 мм?"; // 21
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Размер зёрен в пределах 0,1 - 1 мм?"; // 21
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Размер зёрен в пределах 0,1 - 1 мм?"; // 21
        }

        private void NoRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            p7 = 0;
            panel8.Enabled = true;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Структура характеризуется преобладанием чешуйчатых металлов?"; // 11
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Структура – неполнокристаллическая?"; // 9
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 > 0.5)
            {
                label8.Enabled = false;
                s = "Трахит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Размер зёрен в пределах 0,1 - 1 мм?"; // 21
            else if (p1 > 0.5 && p2 > 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Размер зёрен в пределах 0,1 - 1 мм?"; // 21
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Размер зёрен в пределах 0,1 - 1 мм?"; // 21
            else if (p1 > 0.5 && p2 > 0.5 && p3 > 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5)
                label8.Text = "Размер зёрен в пределах 0,1 - 1 мм?"; // 21
        }
        //-----------------------------------------------------------------------------7

        //-----------------------------------------------------------------------------8
        private void YesRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            p8 = 1;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8) / 8;
                if (p >= 2.1 && p < 3.3)
                    s = "Перидотит";
                else
                    s = "Дунит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 > 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8) / 8;
                if (p >= 2.8 && p < 3.6)
                    s = "Габбро";
                else if (p >= 3.6 && p < 4.2)
                    s = "Пироксенит";
                else
                    s = "Горноблендит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                panel9.Enabled = true;
                label9.Text = "Текстура характеризуется хорошо выраженной сланцеватостью?"; // 12
            }

            else if (p1 > 0.5 && p2 > 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                s = "Песчаник";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                s = "Песок";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void YesNoRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            p8 = 0.7;
            
            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8) / 8;
                if (p >= 2.1 && p < 3.3)
                    s = "Перидотит";
                else
                    s = "Дунит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 > 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8) / 8;
                if (p >= 2.8 && p < 3.6)
                    s = "Габбро";
                else if (p >= 3.6 && p < 4.2)
                    s = "Пироксенит";
                else
                    s = "Горноблендит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                panel9.Enabled = true;
                label9.Text = "Текстура характеризуется хорошо выраженной сланцеватостью?"; // 12
            }
                
            else if (p1 > 0.5 && p2 > 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                s = "Песчаник";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                s = "Песок";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("L:\\ТПУ\\1 курс 2 семестр\\Интеллектуальные системы\\all\\1 лаба\\ека\\lab1\\Приложение 1.docx");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("L:\\ТПУ\\1 курс 2 семестр\\Интеллектуальные системы\\all\\1 лаба\\ека\\lab1\\Приложение 2.docx");
        }

        private void NoYesRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            p8 = 0.3;


            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                panel9.Enabled = true;
                label9.Text = "Текстура характеризуется хорошо выраженной сланцеватостью?"; // 12
            }

            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                s = "Пикрит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 > 0.5)
            {
                s = "Базальт";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (p1 > 0.5 && p2 > 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                s = "Алевралит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (p1 > 0.5 && p2 > 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                s = "Алеврит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void NoRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            p8 = 0;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                panel9.Enabled = true;
                label9.Text = "Текстура характеризуется хорошо выраженной сланцеватостью?"; // 12
            }
                
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                s = "Пикрит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 > 0.5)
            {
                s = "Базальт";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                s = "Алевралит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 > 0.5 && p4 > 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5)
            {
                s = "Алеврит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //-----------------------------------------------------------------------------8

        //-----------------------------------------------------------------------------9
        private void YesRadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            p9 = 1;
            panel10.Enabled = true;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 > 0.5)
                label10.Text = "Отдельность характеризуется тонкой сланцеватостью, киважем?"; // 13
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 < 0.5)
                label10.Text = "Отдельность характеризуется грубой сланцеватостью?"; //14 
        }

        private void YesNoRadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            p9 = 0.7;
            panel10.Enabled = true;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 > 0.5)
                label10.Text = "Отдельность характеризуется тонкой сланцеватостью, киважем?"; // 13
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 < 0.5)
                label10.Text = "Отдельность характеризуется грубой сланцеватостью?"; //14 
        }

        private void NoYesRadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            p9 = 0.3;
            panel10.Enabled = true;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 < 0.5)
                label10.Text = "Данная порода образуется по известнякам?"; // 15
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 > 0.5)
            {
                panel10.Enabled = false;
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9) / 9;
                if (p >= 1.4 && p < 2.3)
                    s = "ПШ";
                else if (p >= 2.3 && p < 3.2)
                    s = "Биотит";
                else
                    s = "Кварц";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void NoRadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            p9 = 0;
            panel10.Enabled = true;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 < 0.5)
                label10.Text = "Данная порода образуется по известнякам?"; // 15
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 > 0.5)
            {
                panel10.Enabled = false;
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9) / 9;
                if (p >= 1.4 && p < 2.3)
                    s = "ПШ";
                else if (p >= 2.3 && p < 3.2)
                    s = "Биотит";
                else
                    s = "Кварц";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //-----------------------------------------------------------------------------9

        //-----------------------------------------------------------------------------10
        private void YesRadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            p10 = 1;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 < 0.5 && p9 < 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10) / 10;
                if (p >= 0.7 && p < 2.05)
                    s = "Кальцит";
                else
                    s = "Доломит";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 < 0.5 && p9 > 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10) / 10;
                if (p >= 1.4 && p < 2.3)
                    s = "Гранат";
                else if (p >= 2.3 && p < 3.2)
                    s = "Кварц";
                else
                    s = "ПШ";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 > 0.5 && p9 > 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10) / 10;
                if (p >= 2.1 && p < 3)
                    s = "Хлорит";
                else if (p >= 3 && p < 3.9)
                    s = "Эпидот";
                else
                    s = "Кварц";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void YesNoRadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            p10 = 0.7;
        }

        private void NoRadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            p10 = 0;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 < 0.5 && p9 < 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10) / 10;
                if (p >= 0.7 && p < 2.05)
                    s = "Кварц";
                else
                    s = "Слюда";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 < 0.5 && p9 > 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10) / 10;
                if (p >= 1.4 && p < 2.75)
                    s = "Амфибол";
                else
                    s = "Плагиоклаз";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 > 0.5 && p9 > 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10) / 10;
                if (p >= 2.1 && p < 2.775)
                    s = "Кварц";
                else if (p >= 2.775 && p < 3.45)
                    s = "Биотит";
                else if (p >= 3.45 && p < 4.125)
                    s = "Мусковит";
                else
                    s = "ПШ";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void NoYesRadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            p10 = 0.3;

            if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 < 0.5 && p9 < 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10) / 10;
                if (p >= 0.7 && p < 2.05)
                    s = "Кварц";
                else
                    s = "Слюда";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 < 0.5 && p9 > 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10) / 10;
                if (p >= 1.4 && p < 2.75)
                    s = "Амфибол";
                else
                    s = "Плагиоклаз";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (p1 > 0.5 && p2 < 0.5 && p3 < 0.5 && p4 < 0.5 && p5 < 0.5 && p6 < 0.5 && p7 < 0.5 && p8 > 0.5 && p9 > 0.5)
            {
                p = (p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10) / 10;
                if (p >= 2.1 && p < 2.775)
                    s = "Кварц";
                else if (p >= 2.775 && p < 3.45)
                    s = "Биотит";
                else if (p >= 3.45 && p < 4.125)
                    s = "Мусковит";
                else
                    s = "ПШ";
                MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //-----------------------------------------------------------------------------10
    }
}
