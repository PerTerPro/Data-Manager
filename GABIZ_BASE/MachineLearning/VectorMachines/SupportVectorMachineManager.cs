using System;
using System.Collections.Generic;
using System.Text;
using GABIZ.Base.Controls;
using GABIZ.Base.MachineLearning.VectorMachines;
using GABIZ.Base.MachineLearning.VectorMachines.Learning;
using GABIZ.Base.Mathematic;
using GABIZ.Base.Statistics.Analysis;
using GABIZ.Base.Statistics.Kernels;

namespace GABIZ.Base.MachineLearning.VectorMachines
{
    public class SupportVectorMachineManager
    {
        public static string svmToString(KernelSupportVectorMachine svm)
        {
            if (svm == null) return null;

            string s = "";
            string temp = "";
            s += svm.Inputs + "~"; //Write input
            int l = svm.SupportVectors.Length;
            s += l + "~"; //Length of support vectors
            for (int i = 0; i < l; i++)
            {
                int n = svm.SupportVectors[i].Length;
                temp = "";
                for (int j = 0; j < n; j++)
                {
                    temp += svm.SupportVectors[i][j] + " ";
                }
                temp = temp.Trim();
                s += temp + "~";
            }

            s += svm.Threshold + "~";

            l = svm.Weights.Length;

            temp = "";
            for (int i = 0; i < l; i++)
            {
                temp += svm.Weights[i] + " ";
            }
            temp = temp.Trim();
            s += temp + "~";

            string[] _kType = svm.Kernel.ToString().Split('.');
            int u = _kType.Length;
            string kType = _kType[u - 1];
            switch (kType)
            {
                case "Gaussian": Statistics.Kernels.Gaussian gKernel = svm.Kernel as Statistics.Kernels.Gaussian;
                    s += "Gaussian" + "~";
                    s += gKernel.Sigma;
                    break;
                case "Polynomial": Polynomial pKernel = svm.Kernel as Polynomial;
                    s += "Polynomial" + "~";
                    s += pKernel.Degree + "~";
                    s += pKernel.Constant;
                    break;
                case "Linear": Linear lKernel = svm.Kernel as Linear;
                    s += "Linear" + "~";
                    s += lKernel.Constant;
                    break;
                case "Sigmoid": Sigmoid sKernel = svm.Kernel as Sigmoid;
                    s += "Sigmoid" + "~";
                    s += sKernel.Gamma + "~";
                    s += sKernel.Gamma;
                    break;
            }
            return s;
        }

        public static KernelSupportVectorMachine stringToSVM(string s)
        {
            string[] sP = s.Split('~');

            int inputs = Convert.ToInt32(sP[0]); //Read inputs
            int l = Convert.ToInt32(sP[1]); //Read number of support vectors
            string[] temp = sP[2].Split(' '); //Read first support vector
            int n = temp.Length;
            double[,] supportVectors = new double[l, n];
            for (int i = 0; i < n; i++)
            {
                supportVectors[0, i] = Convert.ToDouble(temp[i]);
            }
            for (int i = 1; i < l; i++)
            {
                temp = sP[2 + i].Split(' ');
                for (int j = 0; j < n; j++)
                {
                    supportVectors[i, j] = Convert.ToDouble(temp[j]);
                }
            }

            double threshold = Convert.ToDouble(sP[2 + l]);

            string[] _weights = sP[3 + l].Split(' '); //Read weight;
            int wL = _weights.Length;
            double[] weights = new double[wL];
            for (int i = 0; i < wL; i++)
            {
                weights[i] = Convert.ToDouble(_weights[i]);
            }

            IKernel kernel = new Polynomial(2, 1);

            string kernelString = sP[4 + l];
            switch (kernelString)
            {
                case "Gaussian": kernel = new Statistics.Kernels.Gaussian(Convert.ToDouble(sP[5 + l]));
                    break;
                case "Polynomial": kernel = new Polynomial(Convert.ToInt32(sP[5 + l]), Convert.ToDouble(sP[6 + l]));
                    break;
                case "Linear": kernel = new Linear(Convert.ToDouble(sP[5 + l]));
                    break;
                case "Sigmoid": kernel = new Sigmoid(Convert.ToDouble(sP[5 + l]), Convert.ToDouble(sP[6 + l]));
                    break;
            }
            KernelSupportVectorMachine svm = new KernelSupportVectorMachine(kernel, inputs);

            svm.SupportVectors = supportVectors.ToArray();
            svm.Threshold = threshold;
            svm.Weights = weights;

            return svm;
        }

        public static string msvmToString(MulticlassSupportVectorMachine msvm)
        {
            return svmToString(msvm.Machines[0][0]) + "#" + svmToString(msvm.Machines[1][0]) + "#" + svmToString(msvm.Machines[1][1]);
        }

        public static MulticlassSupportVectorMachine stringToMsvm(string s)
        {
            string[] temp = s.Split('#');
            KernelSupportVectorMachine[][] ksvm = new KernelSupportVectorMachine[2][];
            ksvm[0] = new KernelSupportVectorMachine[1];
            ksvm[0][0] = stringToSVM(temp[0]);
            ksvm[1] = new KernelSupportVectorMachine[2];
            ksvm[1][0] = stringToSVM(temp[1]);
            ksvm[1][1] = stringToSVM(temp[2]);

            MulticlassSupportVectorMachine msvm = new MulticlassSupportVectorMachine(ksvm);

            return msvm;
        }
    }
}
