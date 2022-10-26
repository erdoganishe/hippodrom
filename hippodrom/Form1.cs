using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hippodrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet2.Res". При необходимости она может быть перемещена или удалена.
            this.resTableAdapter.Fill(this.hyppodromDataSet2.Res);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet2.Horse". При необходимости она может быть перемещена или удалена.
            this.horseTableAdapter.Fill(this.hyppodromDataSet2.Horse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet2.Cynologist". При необходимости она может быть перемещена или удалена.
            this.cynologistTableAdapter.Fill(this.hyppodromDataSet2.Cynologist);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet2.Race". При необходимости она может быть перемещена или удалена.
            this.raceTableAdapter1.Fill(this.hyppodromDataSet2.Race);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet2.Bet". При необходимости она может быть перемещена или удалена.
            this.betTableAdapter.Fill(this.hyppodromDataSet2.Bet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet.Race". При необходимости она может быть перемещена или удалена.
            this.raceTableAdapter.Fill(this.hyppodromDataSet.Race);

        }
    }
}
