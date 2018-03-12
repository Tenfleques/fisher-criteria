using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦПУТС_1{
    public partial class FormMain : Form{        
        public FormMain() {
            InitializeComponent();            
        }
        
        private void button1_Click(object sender, EventArgs e){
            //to get N value from number field
            int N = 20;
            double A, B;
            double[] x, y, ymodel;
            int l;
            double tablichniFp = 2.2033; // при 5%
            LinearRegression driver = new LinearRegression(N,tablichniFp);
            double y_ = driver.fillModelData();
            double[] SySo = driver.calculateDispersionRelativeToAvg(y_);
            double Fp = driver.getFp();
            
            A = driver.getA();
            B = driver.getB();
            l = driver.getL();

            this.labela.Text = "a: " + A.ToString("#.####");
            this.labelb.Text = "b: " + B.ToString("#.####");
            this.labelequation.Text = "y = " + A.ToString("#.####") + "x + " + B.ToString("#.####");

            if (driver.getError() == 1) {
                this.richTextBoxInfo.AppendText("\n ощибка деление с 0");
                return;
            }

            // расчет критерия Фишера
            double F = SySo[0]/ SySo[1];
            this.labelFp.Text = "критическое значение по критерию Фишера: " + Fp.ToString("#.####");

            this.labelF.Text = "расчетное значение по критерию Фишера: " + F.ToString("#.####");
            //расчет корреляционного отношения
            double correllationRelationShip = (N - l) * SySo[1] / ((N - 1) * SySo[0]);
            if (1 - correllationRelationShip < 0) {
                this.richTextBoxInfo.AppendText("\n ощибка корень сложный");
                return;
            } 
            double tet = Math.Sqrt(1 - correllationRelationShip);
            this.labeltet.Text = "величина корреляционного отношения: "+tet.ToString("#.####");
            this.richTextBoxInfo.AppendText("\nрасчетное значение по критерию Фишера\n" + F.ToString("#.####") + "\nкритическое значение по критерию Фишера\n" + Fp.ToString("#.####") + "\nвеличина корреляционного отношения\n" + tet.ToString("#.####"));

            if (F > Fp) { //Проверка выполнения условия адекватности модели
                this.richTextBoxInfo.AppendText("\nF>Fp: модель адекватна");
                this.labelconclusion.Text = "модель адекватна";
            } else {
                this.richTextBoxInfo.AppendText("\nF<=Fp: модель не адекватна");
                this.labelconclusion.Text = "модель не адекватна";
            }

            x = driver.getX();
            y = driver.getY();
            ymodel = driver.getYModel();

            for (int i = 0; i < 20; ++i) {
                this.chartShow.Series[1].Points.AddXY(x[i], ymodel[i]);
                this.chartShow.Series[0].Points.AddXY(x[i],y[i]);
            }
            this.chartShow.Show();
        }
    }
}
