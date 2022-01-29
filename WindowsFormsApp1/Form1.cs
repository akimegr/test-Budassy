using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int l = 20;

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text = checkedListBox1.SelectedIndexCollection.Count.ToString;
            label1.Text =  checkedListBox1.CheckedItems.Count.ToString() + "/20";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = checkedListBox1.CheckedItems.Count.ToString() + "/20";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] array = new string[checkedListBox1.CheckedItems.Count];

            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                array[i] = checkedListBox1.CheckedItems[i].ToString();
            }

            if (array.Length == l)
            {
                dataGridView1.RowCount = l;
                dataGridView1.Columns[0].HeaderText = "My Header";
                dataGridView1.Columns.Add("1", "Идеальное");
                dataGridView1.Columns.Add("2", "Реальное");
                for (int i = 0; i < array.Length; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = array[i];
                    dataGridView1.Rows[i].Cells[1].Value = "";
                    dataGridView1.Rows[i].Cells[2].Value = "";
                    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                button3.Visible=true;
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("Выберите 20");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int len = dataGridView1.Columns[1].Width;
            int[] checkId = new int[l];
            int[] checkRel = new int[l];
            for(int i = 0; i < l; i++)
            {
                try
                {
                    checkId[i] = Convert.ToInt32((dataGridView1.Rows[i].Cells[1].Value.ToString()));
                    if(Convert.ToInt32((dataGridView1.Rows[i].Cells[1].Value.ToString()))>20 || Convert.ToInt32((dataGridView1.Rows[i].Cells[1].Value.ToString())) < 1)
                    {
                        MessageBox.Show("Введите значения от 1 до 20");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Проверьте длину 'Идельное'");
                    return;
                }
                
            }
            for (int i = 0; i < l; i++)
            {
                try
                {
                    checkRel[i] = Convert.ToInt32((dataGridView1.Rows[i].Cells[2].Value.ToString()));
                    if (Convert.ToInt32((dataGridView1.Rows[i].Cells[1].Value.ToString())) > 20 || Convert.ToInt32((dataGridView1.Rows[i].Cells[1].Value.ToString())) < 1)
                    {
                        MessageBox.Show("Введите значения от 1 до 20");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Проверьте длину 'Реальное'");
                    return;
                }

            }
            bool tmp = true;
            
            for (int i = 0; i < l; i++)
               {
                    for (int z = i + 1; z < l; z++)
                    {
                        if (checkId[i] == checkId[z])
                        {
                            tmp = false;
                            MessageBox.Show("Есть одинаковые значения " + checkId[i].ToString());
                        }
                    }
               }
            for (int i = 0; i < l; i++)
            {
                for (int z = i + 1; z < l; z++)
                {
                    if (checkRel[i] == checkRel[z])
                    {
                        tmp = false;
                        MessageBox.Show("Есть одинаковые значения " + checkRel[i].ToString());
                    }
                }
            }


            if (tmp)
            {
                double sum = 0;
               for (int i = 0; i < l; i++)
                {
                   sum+=Math.Pow(Math.Abs(checkRel[i] - checkId[i]), 2);
                }
                double r = 1 - 0.00075 * sum;
                string res = "ВАШ РЕЗУЛЬТАТ: " + r.ToString() + "\r\n\r\n";
                if (-0.37<=r && r <= 0.37)
                {
                    MessageBox.Show(res+ "Результат не менее -0,37 и не более +0,37 указывает на слабую связь (или вообще ее отсутствие)\r\n между представлениями человека о «Я-идеальном» и о «Я-реальном». \r\n Такой результат может быть показателем неправильных расчетов или же неадекватным представлением человека о своих идеальных и реальных качествах. ");
                }
                if(0.38<=r && r <= 1)
                {
                    MessageBox.Show(res + "Результат от +0,38 до +1 говорит о положительной связи между «Я-идеальным» и «Я-реальным».");
                }
                if(0.38<r && r <= 0.89)
                {
                    MessageBox.Show(res + "Значения от +0,39 до +0,89 трактуются как адекватная самооценка с тенденцией к завышению.");
                }
                if(0.89<r && r <= 1)
                {
                    MessageBox.Show(res + "Значения же от +0,89 до +1 зачастую указывают на неадекватно завышенную самооценку.");

                }
                if(-1<=r && -0.38 >= r)
                {
                    MessageBox.Show(res + "Результат от -0,38 до -1 указывает на отрицательную связь между «Я-идеальным» и «Я-реальным».\r\n У человека расходятся представления о том, каким он хочет быть и тем, какой он в реальности.\r\n Значение можно трактовать как тенденцию к заниженной самооценке, и чем ближе результат к -1, тем больше несоответствий. ");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" В первой колонке выбираются 20 качеств идеального человека(выбрать: два раза нажать на слово, должна поставится галочка в квадрат, или прямым нажатием на квадратик, должна поставится галочка в квадрат), чтобы убрать галочку нажмите на галочку снова. При выбирании нового качества счётчик обновляется автоматически, НО может быть проблема с авто увеличением счётчика. Поэтому, для проверки количества выбранных полей нажимается кнопка 'ОБНОВИТЬ'.\r\n После того, когда счётчик при последним обновлении показал цифру 20, жмём кнопку 'ВЫБРАТЬ'. \r\n У нас появляется новое поле. Напротив каждого качества в этом поле вводим значения в соответствии с заданием (ОБЯЗАТЕЛЬНО вводить только цифры без пробелов!). \r\n После ввода полей нажимаем 'результат' и смотрим наш результат. ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Почему каждому человеку стоит пройти тестирование?\r\n\r\n\r\n Методика разработана известным советским психологом Сергеем Андреевичем Будасси в 1970 - х.Тест Будасси даже в наши дни успешно применяют психологи во всем мире. \r\n\r\n Анализ помогает определить «Я - концепцию», среднее значение «Я - реального» и «Я - идеального». Именно «Я - концепция» влияет на выбор типа поведения человека, который, в свою очередь, и определяет направление деятельности, поступки и коммуникации.\r\n\r\n Почему важно понимать свою «Я - концепцию»? Не все, что мы думаем о самих себе, есть на 100 % реальным.Некоторые аспекты нашей личности не воспринимаются сознанием и реализуются нами неосознанно.Тест Будасси позволяет определить уровень нашей самооценки, и на основе этих знаний корректировать свои поступки и решения.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Инструкция к тесту Будасси\r\n\r\n\r\n Перед вами 48 слов, обозначающих свойства личности. Далее, вам необходимо выполнить 3 шага:\r\n 1 шаг. Из списка качеств выберите 20, которые, по вашему мнению, имеет идеальный человек. Рядом с выбранными качествами в левой колонке поставьте галочку.\r\n 2 шаг. Теперь из этих 20 качеств выберите наиболее неприятные вам. Напротив каждого качества в колонке «Идеальное» (2 колонка) проставьте цифры от 1 до 20, где 1 — наиболее неприятное качество, 20 — наименее неприятное. \r\n 3 шаг. И последний шаг — отметьте из 20 качеств наименее характерные для вас. В колонке «Реальное» (3 колонка) проставьте цифру напротив каждого качества от 1 до 20, где 1 — наименее характерное качество, 20 — наиболее характерное. \r\n ЗНАЧЕНИЯ ОТ 1 ДО 20 НЕ ДОЛЖНЫ ПОВТОРЯТЬСЯ!!!\r\n\r\n После правильного выполнения всех пунктов смело жмите на 'результат'!");
        }
    }
}
