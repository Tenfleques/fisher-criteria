using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЦПУТС_1 {

    class LinearRegression {
        private double[] yexp, ymodel;
        private double[] xexp;
        double Fp;
        int N, l;
        int error; // 0 everything okay,  1 division by 0, 2 square root of negative

        private double A, B;
        public LinearRegression(int n, double fp) {
            error = 0;
            Fp = fp;
            N = n;
            l = 2; //linear constant
            //get values from file or std input
            yexp = new double[20] { 24.89, 24.3, 23.6, 22.81, 21.94, 21.02, 20.09, 19.6, 18.23, 17.2, 16.5, 15.48, 14.63, 13.75, 13.01, 12.27, 11.62, 11.01, 10.322, 9.81 };
            xexp = new double[20] { 0.01, 0.09, 0.18, 0.25, 0.33, 0.41, 0.49, 0.57, 0.65, 0.73, 0.81, 0.89, 0.97, 1.05, 1.13, 1.21, 1.29, 1.37, 1.45, 1.53 };
            ymodel = new double[20];
            for (int i = 0; i < N; ++i)
                ymodel[i] = 0.0;
        }
        private double[] getDeterminant() {
            double k11, k12, k21, k22, p1, p2;
            p1 = p2 = k11 = k12 = 0;
            double D, DA, DB;
            for (int i = 0; i < N; ++i) {
                k11 += xexp[i] * xexp[i];
                k12 += xexp[i];
                p1 += xexp[i] * yexp[i];
                p2 += yexp[i];
            }
            k21 = k12;
            k22 = N;
            D = k11 * k22 - k21 * k12;
            DA = p1 * k22 - p2 * k12;
            DB = k11 * p2 - k21 * p1;
            return new double[3] { D, DA, DB };
        }
        public double fillModelData() {
            /*Расчет дисперсии относительно среднего,
              остаточной дисперсии, критерия Фишера
              и корреляционного отношения
             */
            double[] D = getDeterminant();

            if (D[0] == 0) {
                error = 1; 
                return 0;
            }
            //Определение искомых параметров
            A = D[1] / D[0];
            B = D[2] / D[0];

            double S = 0;
            for (int i = 0; i < N; ++i) {
                //Определение искомых параметров модели
                ymodel[i] = A * xexp[i] + B;
                S += yexp[i];
            }
            return S / N; /*расчет среднего*/
        }
        public double[] calculateDispersionRelativeToAvg(double y_) {
            /* расчет дисперсии относительно среднего, остаточной дисперсии*/
            double Sy = 0, So = 0;
            for (int i = 0; i < N; ++i) {
                Sy += (yexp[i] - y_) * (yexp[i] - y_);
                So += (yexp[i] - ymodel[i]) * (yexp[i] - ymodel[i]);
            }
            double S2y = Sy / (N - 1);
            double S2o = So / (N - l);
            return new double[2] { S2y, S2o };
        }
        public double getA() {
            return A;
        }
        public double getB() {
            return B;
        }
        public double getFp() {
            return Fp;
        }
        public double[] getY() {
            return yexp;
        }
        public double[] getYModel() {
            return ymodel;
        }
        public double[] getX() {
            return xexp;
        }
        public int getL() {
            return l;
        }
        public int getError() {
            return error;
        }

    }
    
}
