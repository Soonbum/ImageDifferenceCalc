using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImageDifferenceCalc
{
    public partial class ImageDifferenceCalc : Form
    {
        private List<string> imageList1 = new List<string>();
        private List<string> imageList2 = new List<string>();
        private double GapValue = 0;

        public ImageDifferenceCalc()
        {
            InitializeComponent();
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            if (imageList1.Count != imageList2.Count)
            {
                MessageBox.Show("각 리스트에 동일한 개수의 이미지가 있어야 합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            progressBar.Visible = true;
            progressBar.Minimum = 0;
            progressBar.Maximum = imageList1.Count;
            progressBar.Value = 0;

            for (int i = 0; i < imageList1.Count; i++)
            {
                GapValue = 0;
                Mat imgA = CvInvoke.Imread(imageList1[i], ImreadModes.Color);
                Mat imgB = CvInvoke.Imread(imageList2[i], ImreadModes.Color);

                if (imgA.Size != imgB.Size)
                {
                    MessageBox.Show($"이미지 크기가 다릅니다: {imageList1[i]} vs {imageList2[i]}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }

                Mat diffAB = new Mat();
                Mat diffBA = new Mat();

                CvInvoke.AbsDiff(imgA, imgB, diffAB);       // 왼쪽에서 오른쪽 이미지를 뺀 차영상 이미지 (diffAB)
                CvInvoke.AbsDiff(imgB, imgA, diffBA);       // 오른쪽에서 왼쪽 이미지를 뺀 차영상 이미지 (diffBA)

                // 각 픽셀의 모든 합 계산
                MCvScalar sumDiffAB = CvInvoke.Sum(diffAB);
                MCvScalar sumDiffBA = CvInvoke.Sum(diffBA);
                GapValue += (sumDiffAB.V0 + sumDiffAB.V1 + sumDiffAB.V2);
                GapValue += (sumDiffBA.V0 + sumDiffBA.V1 + sumDiffBA.V2);

                // 차이 값을 listBox에 추가
                listBox3.Items.Add($"{Path.GetFileName(imageList1[i].ToString())}: {GapValue.ToString()}");

                progressBar.Value = i + 1;
                Application.DoEvents();
            }

            progressBar.Visible = false;
            if (imageList1.Count > 0)
            {
                MessageBox.Show("이미지 비교가 완료되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addToListBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "이미지 파일|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageList1.AddRange(openFileDialog.FileNames);
                listBox1.Items.AddRange(openFileDialog.FileNames.Select(f => System.IO.Path.GetFileName(f)).ToArray());
            }
        }

        private void addToListBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "이미지 파일|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageList2.AddRange(openFileDialog.FileNames);
                listBox2.Items.AddRange(openFileDialog.FileNames.Select(f => System.IO.Path.GetFileName(f)).ToArray());
            }
        }
    }
}
